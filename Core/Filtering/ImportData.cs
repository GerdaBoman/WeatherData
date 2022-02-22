using DataAccess.Data;
using DataAccess.Models;
using LumenWorks.Framework.IO.Csv;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DataAccess
{
    public class ImportData : FileReader 
    {
        public static void ImportFile(string path)// Purpose: Import a list to an SQLDB
        {

            using SqlConnection importtest = new(@"data source=(localdb)\mssqllocaldb;initial catalog=robogender;integrated security=true");
            importtest.Open();//opens a connection the the database 

            FileReader reader = new();
            List<SearchParameters> parameters = reader.Procesor(reader.Filter(path));//Gets the list of the CSV entities
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
        public static void EFImport(string path)
        {
            int i = 0;
            FileReader reader = new();
            List<SearchParameters> parameters = reader.Procesor(reader.Filter(path));
            using var contect = new RoboGenderContext();
            {
                foreach(SearchParameters param in parameters)
                {
                    List<Weather> wArr = new();
                    wArr.Add(new Weather
                    {
                        Datum = DateTime.ParseExact(param.csvDatum, "yyyy-M-dd H:mm", CultureInfo.InvariantCulture),
                        Plats = param.csvPlats,
                        Temp = double.Parse(param.csvTemp, NumberStyles.Float, CultureInfo.InvariantCulture),
                        Luftfuktighet = double.Parse(param.csvLuftFuktighet)
                    });
                    
                    

                    contect.Weathers.AddRangeAsync(wArr);

                    i++;
                    if(i== 27955)
                    {
                        contect.SaveChanges();
                        i= 0;
                    }
                }
            }
        }
        public static bool DataExsist()
        {
            RoboGenderContext context = new();
            var exsist = context.Weathers.Any();
            return exsist;
        }

    }
}
