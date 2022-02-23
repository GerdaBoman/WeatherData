using DataAccess.Data;
using DataAccess.Models;
using System.Globalization;

namespace DataAccess
{
    public class csvFormatting : csvFilter
    {
        public static void EFImport(string path) //Purpose Using EF to Import 
        {
            int i = 0;
            csvFilter reader = new();
            List<SearchParameters> parameters = reader.Procesor(reader.Filter(path));
            using var contect = new RoboGenderContext();
            {
                foreach (SearchParameters param in parameters)
                {
                    List<Weather> wArr = new();
                    wArr.Add(new Weather//Makes sure everything is the right format 
                    {
                        Datum = DateTime.ParseExact(param.csvDatum, "yyyy-M-dd H:mm", CultureInfo.InvariantCulture),
                        Plats = param.csvPlats,
                        Temp = double.Parse(param.csvTemp, NumberStyles.Float, CultureInfo.InvariantCulture),
                        Luftfuktighet = double.Parse(param.csvLuftFuktighet)
                    });

                    contect.Weathers.AddRangeAsync(wArr);

                    i++;
                    if (i == 139775) //saves it after it has loaded up everyhing to save time
                    {
                        contect.SaveChanges();
                        i = 0;
                    }
                }
            }
        }
    }
}