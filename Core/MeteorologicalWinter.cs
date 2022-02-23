using DataAccess.Data;

namespace Core
{
    public class MeteorologicalWinter
    {
        public string OfficialWinterDay()
        {
            RoboGenderContext db = new();
            string winter = "";

            var date = (from a in db.WeatherAverages
                        where a.TempAverage <= 0 && a.Place == "Ute"
                        select a.Date).ToList();

            for (int i = 0; i < date.Count - 5; i++)
            {
                if (date[i + 4] == date[i].AddDays(4))
                {
                    return winter = date[i + 4].ToShortDateString();
                }
            }

            return "Too warm for winter!";
        }
    }
}
