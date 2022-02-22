using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AverageCalculation
    {
        public static WeatherAverage average(string place, int year, int month, int day, List<double> dayLenght, int seasonCheck)
        {
            MoldCalculation mold = new();

            List<double> avergageDayTemp = csvImport.Daily_AverageTemperature(place, year, month, day);
            List<double> averageDayHum = csvImport.Daily_AverageHumidity(place, year, month, day);

            WeatherAverage item1 = new();
            string

                date = new($"{year}-{month}-{day}");

            int moldrisk = mold.moldCalc(int.Parse(Math.Round(avergageDayTemp.Average()).ToString()), int.Parse(Math.Round(averageDayHum.Average()).ToString()));

            if (place.Trim() == "Ute")
            {
                dayLenght.Add(Math.Round(avergageDayTemp.Average(), 0));
            }
            string season = "";

            switch (dayLenght.Count)
            {
                case 5:
                    {
                        if (dayLenght[0] <= 1 && dayLenght[1] <= 1 && dayLenght[2] <= 1 && dayLenght[3] <= 1 && dayLenght[4] <= 1)
                        {
                            dayLenght.Clear();
                            seasonCheck = 0;
                        }

                        break;
                    }
                default:
                    {
                        seasonCheck = 1;
                        dayLenght.Clear();
                        break;
                    }
            }
            switch (seasonCheck)
            {
                case 0:
                    {
                        season = "Winter";
                        break;
                    }
                case 1:
                    { season = "Fall"; break; }
            }
            item1.Date = DateTime.ParseExact(date, "yyyy-M-d", CultureInfo.InvariantCulture);
            item1.Place = place;
            item1.TempAverage = avergageDayTemp.Average();
            item1.HumAverage = averageDayHum.Average();
            item1.MoldRisk = moldrisk;
            item1.Seasons = season;

            return item1;
        }
    }
}
