using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    
    public  class AverageTemperaturePerDay
    {
        private RoboGenderContext _contex;

        public AverageTemperaturePerDay(RoboGenderContext context)
        {
            _contex = context;  
        }

        public IQueryable AvgPerDayInside(DateTime date)
        {
            var results = (from w in _contex.Weathers
                           where w.Datum == date && w.Plats == "Inne"
                           group w by w.Plats into ws
                           select new
                           {
                               Datum = ws.Key,
                               Plats = ws.Key,
                               Temperature = ws.Average(w => w.Temp),
                               Humidity = ws.Average(w => w.Luftfuktighet)
                           });
            return results;
        }
    }
}
