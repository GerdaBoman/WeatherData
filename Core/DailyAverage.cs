using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DailyAverage
    {
        public double averCalc(string place, int year, int month, int day)
        {

            List<double> avergageDayTemp = DataSending.Daily_Average(place, year, month, day);
            List<double> averageDayHum = DataSending.Daily_AverageHum(place, year, month, day);
            return 0;
        }
    }
}
