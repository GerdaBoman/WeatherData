using DataAccess;
using DataAccess.Models;
using System.Globalization;

namespace Core
{
    public class AverageCalculation
    {
        public WeatherAverage average(string place, int year, int month, int day) //Purpose Calculate all average values 
        {
            MoldCalculation mold = new();

            double avergageDayTemp = CsvImport.Daily_AverageTemperature(place, year, month, day).Average();//Temåature
            double averageDayHum = CsvImport.Daily_AverageHumidity(place, year, month, day).Average();//Humidety 

            WeatherAverage item1 = new();
            string date = new($"{year}-{month}-{day}"); //date

            int moldrisk = mold.MoldCalculator(int.Parse(Math.Round(avergageDayTemp).ToString()), //Mold
                                         int.Parse(Math.Round(averageDayHum).ToString()));

            item1.Date = DateTime.ParseExact(date, "yyyy-M-d", CultureInfo.InvariantCulture);
            item1.Place = place;
            item1.TempAverage = avergageDayTemp;
            item1.HumAverage = averageDayHum;
            item1.MoldRisk = moldrisk;

            return item1;
        }
    }
}