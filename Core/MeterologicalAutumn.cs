using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MeterologicalAutumn
    {
        public string OfficialAutumnDay()
        {
            RoboGenderContext db = new();
            string autumn = "";

            var date = (from a in db.WeatherAverages
                        where a.TempAverage >= 0 && a.TempAverage <= 10 && a.Place == "Ute"
                        select a.Date).ToList();

            for (int i = 0; i < date.Count-5; i++)
            {
                if (date[i + 4] == date[i].AddDays(4))
                {
                    return autumn = date[i+4].ToShortDateString();
                }
            }

            return "Automn is not here yet!";
        }
    }
}
