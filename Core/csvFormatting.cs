using Core;
using DataAccess.Data;
using DataAccess.Models;
using LumenWorks.Framework.IO.Csv;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DataAccess
{
    public class csvFormatting : csvFilter 
    {
        public static void EFImport(string path)
        {
            int i = 0;
            csvFilter reader = new();
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
    }
}