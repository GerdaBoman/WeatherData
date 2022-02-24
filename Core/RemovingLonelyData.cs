using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RemovingLonelyData
    {
        public void RemovingSingles()
        {
            RoboGenderContext db = new RoboGenderContext();

            var allDates = (from d in db.Weathers
                            select d).ToList();

            for (int i = 0; i < allDates.Count-1; i++)
            {
                if (allDates[i].Datum == allDates[i + 1].Datum && allDates[i].Plats == "Inne" && allDates[i + 1].Plats == "Ute")
                {
                    continue;
                }
                else if (allDates[i].Datum == allDates[i + 1].Datum && allDates[i].Plats == "Inne" && allDates[i + 1].Plats != "Ute" )
                {
                    allDates.RemoveAt(i);
                }
                else if (allDates[i].Datum == allDates[i + 1].Datum && allDates[i].Plats != "Inne" && allDates[i + 1].Plats == "Ute" )
                {
                    allDates.RemoveAt(i + 1);
                }
                
            }

        }
    }
}
