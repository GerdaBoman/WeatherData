using DataAccess;
using DataAccess.Models;
using System.Globalization;

namespace Core
{
    public class AverageCalculation
    {
        public static WeatherAverage average(string place, int year, int month, int day, List<double> dayLenght, int seasonCheck) //Purpose Calculate all average values 
        {
            MoldCalculation mold = new();

            List<double> avergageDayTemp = CsvImport.Daily_AverageTemperature(place, year, month, day);//Temåature
            List<double> averageDayHum = CsvImport.Daily_AverageHumidity(place, year, month, day);//Humidety 

            WeatherAverage item1 = new();
            string date = new($"{year}-{month}-{day}"); //date

            int moldrisk = mold.MoldCalculator(int.Parse(Math.Round(avergageDayTemp.Average()).ToString()), //Mold
                                         int.Parse(Math.Round(averageDayHum.Average()).ToString()));

            if (place.Trim() == "Ute")
            {
                dayLenght.Add(Math.Round(avergageDayTemp.Average(), 0));
            }
            string season = "";

            switch (dayLenght.Count)    //Might not be the best calculation for winter but the best i could do for now
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