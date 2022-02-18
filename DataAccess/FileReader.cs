using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FileReader
    {
        public List<SearchParameters> filter(string connection)
        {
            static string RemoveNonNumeric(string value) => Regex.Replace(value, "[^0-9.]", "");

            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(connection)), true))
            {
                csvTable.Load(csvReader);
            }
            var searches = new List<SearchParameters>();

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                searches.Add(new SearchParameters
                {
                    csvDatum = csvTable.Rows[i][0].ToString(),
                    csvPlats = csvTable.Rows[i][1].ToString(),
                    csvTemp = RemoveNonNumeric(csvTable.Rows[i][2].ToString()),
                    csvLuftFuktighet = RemoveNonNumeric(csvTable.Rows[i][3].ToString())
                });
            }
            return searches;
        }
        public List<SearchParameters> procesor(List<SearchParameters> searches)
        {


            var GroupByMultipleKeysMS = searches.GroupBy(x => new { x.csvDatum, x.csvPlats, x.csvTemp })
                                                    .Where(g => g.Count() > 1)
                                                    .Select(x => x.Key);
            while (GroupByMultipleKeysMS.Count() > 0)
            {
                foreach (var group in GroupByMultipleKeysMS)
                {
                    int index = searches.FindIndex(x => x.csvDatum == group.csvDatum && x.csvPlats == group.csvPlats);
                    searches.RemoveAt(index);
                }
            }
            return searches;
        }
    }
}