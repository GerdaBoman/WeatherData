using DataAccess.Data;
using DataAccess.Models;

namespace DataAccess
{
    public class AverageImport
    {
        public async Task AverageDB(WeatherAverage average)//Purpose Saves the average data calculations 
        {
            using var contect = new RoboGenderContext();
            {
                contect.WeatherAverages.AddRangeAsync(average);

                contect.SaveChangesAsync();
            }
        }
    }
}