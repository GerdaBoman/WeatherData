using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataSending //Purpose: send data out of DataAccess
    {//has not yet figured out how to send out 2 columns in 1 list
        public static List<double> Daily_Average(string place, int year, int month, int day)
        {

            using var context = new RoboGenderContext();
            {
                var weather = context.Weathers.Where(w => w.Plats == place && w.Datum.Year == (year) &&
                                                                              w.Datum.Month == (month) &&
                                                                              w.Datum.Day == (day))
                                              .Select(s => s.Temp);

                return weather.ToList();
            }
        }

        public static List<double> Daily_AverageHum(string place, int year, int month, int day)
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
