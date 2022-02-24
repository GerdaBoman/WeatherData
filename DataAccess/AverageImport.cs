using DataAccess.Data;
using DataAccess.Models;

namespace DataAccess
{
    public class AverageImport
    {
        public static void AverageDB(WeatherAverage average)//Purpose Saves the average data calculations 
        {
            using var context = new RoboGenderContext();
            {
                context.WeatherAverages.AddRangeAsync(average);

                context.SaveChanges();
            }
        }
    }
}