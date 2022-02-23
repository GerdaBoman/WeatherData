using DataAccess.Data;
using DataAccess.Models;

namespace DataAccess
{
    public class AvrageImport
    {
        public static void AvrageDB(WeatherAverage average)//Purpose Saves the average data calculations 
        {
            using var contect = new RoboGenderContext();
            {
                contect.WeatherAverages.AddRangeAsync(average); 

                contect.SaveChanges();
            }
        }
    }
}