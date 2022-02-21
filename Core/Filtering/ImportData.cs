using LumenWorks.Framework.IO.Csv;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace DataAccess
{
    public class ImportData : FileReader 
    {
        public static void ImportFile(string path)// Purpose: Import a list to an SQLDB
        {

            using SqlConnection importtest = new(@"data source=(localdb)\mssqllocaldb;initial catalog=robogender;integrated security=true");
            importtest.Open();//opens a connection the the database 

            List<SearchParameters> parameters = Procesor(Filter(path));//Gets the list of the CSV entities
            foreach (var param in parameters)//sends the data to the DB with sql script 
            {
                var sql = "insert into robogender.dbo.weather values(" +
                     "cast('" + param.csvDatum + "' as smalldatetime)" + ",'"
                              + param.csvPlats + "'," + param.csvTemp + ","
                              + param.csvLuftFuktighet + ")";

                var cmd = new SqlCommand
                {
                    CommandText = sql,
                    CommandType = CommandType.Text,
                    Connection = importtest
                };
                cmd.ExecuteNonQuery();
            }
            importtest.Close();
        }

    }
}
