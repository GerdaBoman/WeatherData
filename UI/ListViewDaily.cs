using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class ListViewDaily
    {
        public static ListViewItem listDaily(string place, int year, int month, int day)
        {
            MoldCalculation mold = new();
            InsidePanel inside = new();
           
            inside.listView1.BeginUpdate();


            List<double> avergageDayTemp = Avg_Calucations.Daily_AverageTemperature(place, year, month, day);
            List<double> averageDayHum = Avg_Calucations.Daily_AverageHumidity(place, year, month, day);
            ListViewItem item1 = new($"{year}-{month}-{day}");

            int moldrisk = mold.moldCalc(int.Parse(Math.Round(avergageDayTemp.Average()).ToString()), int.Parse(Math.Round(averageDayHum.Average()).ToString()));

            item1.SubItems.Add(place);
            item1.SubItems.Add(Math.Round(avergageDayTemp.Average(), 2).ToString());
            item1.SubItems.Add(Math.Round(averageDayHum.Average(), 2).ToString());
            item1.SubItems.Add(moldrisk.ToString());

            return item1 ;
        }
    }
}
