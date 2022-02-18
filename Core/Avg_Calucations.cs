using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Avg_Calucations
    {
        public List<double> Daily_AverageTemperature(string place, int year, int month, int day)
        {
            
            using var context = new RoboGenderContext();
            {
                var weather = context.Weathers.Where(w => w.Plats == place && w.Datum.Year == (year) &&   
                                                                              w.Datum.Month == (month) && 
                                                                              w.Datum.Day == (day))
                                              .Select(s =>s.Temp);

                return weather.ToList();
            }
        }

        public List<double> Daily_AverageHumidity(string place, int year,int month, int day)
        {

            using var context = new RoboGenderContext();
            {
                var weather = context.Weathers.Where(w => w.Plats == place && w.Datum.Year == (year) &&
                                                                              w.Datum.Month == (month) &&
                                                                              w.Datum.Day == (day))
                                              .Select(s => s.Luftfuktighet);

                return weather.ToList();
            }
        }

    }
}
