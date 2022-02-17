using DataAccess.Data;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    
    public  class AverageTemperaturePerDay
    {

        public AverageTemperaturePerDay()
        {

        }
    

        public void AvgPerDayInside(DateTime date)
        {
            using (RoboGenderContext _contex = new RoboGenderContext())
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
                               }).ToList();
                
                
            }
            
        }
    }
}
