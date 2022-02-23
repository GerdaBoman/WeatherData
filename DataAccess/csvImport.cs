using DataAccess.Data;
using DataAccess.Models;

namespace DataAccess
{
    public class csvImport //Purpose: send data out of DataAccess
    {//has not yet figured out how to send out 2 columns in 1 list
        public static List<double> Daily_AverageTemperature(string place, int year, int month, int day)
        {
            using var context = new RoboGenderContext();
            {
                var weather = context.Weathers.Where(w => w.Plats == place && w.Datum.Year == year &&
                                                                              w.Datum.Month == month &&
                                                                              w.Datum.Day == day)
                                              .Select(s => s.Temp);

                return weather.ToList();
            }
        }

        public static List<double> Daily_AverageHumidity(string place, int year, int month, int day)
        {
            using var context = new RoboGenderContext();
            {
                var weather = context.Weathers.Where(w => w.Plats == place && w.Datum.Year == year &&
                                                                              w.Datum.Month == month &&
                                                                              w.Datum.Day == day)
                                              .Select(s => s.Luftfuktighet);

                return weather.ToList();
            }
        }

        public static List<DateTime> date()
        {
            using var context = new RoboGenderContext();
            {
                var weather = context.Weathers.Select(s => s.Datum);

                return weather.ToList();
            }
        }

        public static List<string> DailyPlace(int year, int month, int day)
        {
            using var context = new RoboGenderContext();
            {
                var weather = context.Weathers.Where(w => w.Datum.Year == year &&
                                                                              w.Datum.Month == month &&
                                                                              w.Datum.Day == day)
                                              .Select(s => s.Plats);

                return weather.ToList();
            }
        }
        public static List<WeatherAverage> outportAverage()
        {
            using var context = new RoboGenderContext();
            {
                var weathers = context.WeatherAverages.Select(s=>s).ToList();
                return weathers;
            }
        }
        public static bool DataExsist()
        {
            RoboGenderContext context = new();
            var exsist = context.WeatherAverages.Any();
            return exsist;
        }

    }
}