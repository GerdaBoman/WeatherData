using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataSending
    {
        public List<double> Daily_Average(string place, string year, string month, string day,string output)
        {
            
            using var context = new RoboGenderContext();
            {
                var weather = context.Weathers.Where(w => w.Plats == place && w.Datum.Year == int.Parse(year) &&   
                                                                              w.Datum.Month == int.Parse(month) && 
                                                                              w.Datum.Day == int.Parse(day))
                                              .Select(s =>s.Temp);

                return weather.ToList();
            }
        }
    }
}
