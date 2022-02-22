using Core;
using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AvrageImport
    {
        public static void AvrageDB(WeatherAverage average)
        {

            using var contect = new RoboGenderContext();
            {


                contect.WeatherAverages.AddRangeAsync(average);


                contect.SaveChanges();


            }
        }
    }
}
