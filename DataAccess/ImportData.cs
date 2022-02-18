using LumenWorks.Framework.IO.Csv;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace DataAccess
{
    public class ImportData : FileReader
    {
        public void ImportFile(string path)
        {
            var csvTable = new DataTable();

            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(path)), true))
            {
                csvTable.Load(csvReader);
            }

            static string RemoveNonNumeric(string value) => Regex.Replace(value, "[^0-9.]", "");


            using (SqlConnection importtest = new SqlConnection(@"data source=(localdb)\mssqllocaldb;initial catalog=robogender;integrated security=true"))
            {
                importtest.Open();

                //Fix the path so that its a connection.Text


                List<SearchParameters> parameters = procesor(filter(path));
                foreach (var param in parameters)
                {
                    var sql = "insert into robogender.dbo.weather values(" +
                         "cast('" + param.csvDatum + "' as smalldatetime)" + ",'"  
                                  + param.csvPlats + "'," + param.csvTemp + "," 
                                  + param.csvLuftFuktighet + ")";

                    var cmd = new SqlCommand();
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = importtest;
                    cmd.ExecuteNonQuery();
                }
                importtest.Close();


            }
        }

    }
}
