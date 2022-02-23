
﻿using Core;


namespace UI
{
    public class ListViewDaily
    {
        public static ListViewItem listDaily(string place, int year, int month, int day, List<double> dayLenght, int seasonCheck)
        {
            MoldCalculation mold = new();
            InsideForm inside = new();

            inside.listView1.BeginUpdate();

            List<double> avergageDayTemp = csvImport.Daily_AverageTemperature(place, year, month, day);
            List<double> averageDayHum = csvImport.Daily_AverageHumidity(place, year, month, day);

            ListViewItem item1 = new();
            if (day.ToString().Length == 1)
            {
                string dayLength = $"0{day}";
                item1 = new($"{year}-{month}-{dayLength}");
            }
            else
            {
                item1 = new($"{year}-{month}-{day}");
            }
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
            item1.SubItems.Add(place);
            item1.SubItems.Add(Math.Round(avergageDayTemp.Average(), 2).ToString());
            item1.SubItems.Add(Math.Round(averageDayHum.Average(), 2).ToString());
            item1.SubItems.Add(moldrisk.ToString());
            item1.SubItems.Add(season);

            return item1;
        }
    }
}