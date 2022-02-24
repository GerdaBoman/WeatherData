using Core.Filtering;
using DataAccess.Data;
using DataAccess.Models;
using System.Globalization;

namespace DataAccess
{
    public class CsvFormatting : CsvFilter
    {
        public void EFImport(string path) //Purpose Using EF to Import 
        {
            int i = 0;
            CsvFilter reader = new();
            List<SearchParameters> parameters = reader.ProcessingData(reader.FilteringData(path));
            using var context = new RoboGenderContext();
            {
                foreach (SearchParameters param in parameters)
                {
                    List<Weather> weatherArray = new();
                    weatherArray.Add(new Weather//Makes sure everything is the right format 
                    {
                        Datum = DateTime.ParseExact(param.csvDatum, "yyyy-M-dd H:mm", CultureInfo.InvariantCulture),
                        Plats = param.csvPlats,
                        Temp = double.Parse(param.csvTemp, NumberStyles.Float, CultureInfo.InvariantCulture),
                        Luftfuktighet = double.Parse(param.csvLuftFuktighet)
                    });

                    context.Weathers.AddRangeAsync(weatherArray);
                    //TODO: Change numbers
                    i++;
                    if (i == 139775) //saves it after it has loaded up everyhing to save time
                    {
                        context.SaveChanges();
                        i = 0;
                    }
                }
            }
        }
    }
}