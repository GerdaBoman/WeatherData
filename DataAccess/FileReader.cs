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
        public static List<SearchParameters> Filter(string connection) //Purpose: Read in the data from a CSV file 
        {
            static string RemoveNonNumeric(string value) => Regex.Replace(value, "[^0-9.]", ""); //Made to remove any unwanted Char

            var searches = new List<SearchParameters>();
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(connection)), true)) //Loads the file so it can be read
            {
                csvTable.Load(csvReader);
            }

            for (int i = 0; i < csvTable.Rows.Count; i++)//Goes through all the rows in said file and adds it to a list 
            {
                searches.Add(new SearchParameters
                {
                    csvDatum = csvTable.Rows[i][0].ToString(),
                    csvPlats = csvTable.Rows[i][1].ToString(),
                    csvTemp = RemoveNonNumeric(csvTable.Rows[i][2].ToString().Trim()),
                    csvLuftFuktighet = RemoveNonNumeric(csvTable.Rows[i][3].ToString().Trim())
                });
            }
            return searches;
        }
        public static List<SearchParameters> Procesor(List<SearchParameters> searches) //Purpose: Remove all duplicates 
        {


            var GroupByMultipleKeysMS = searches.GroupBy(x => new { x.csvDatum, x.csvPlats, x.csvTemp }) //Looks for all duplicates 
                                                    .Where(g => g.Count() > 1)
                                                    .Select(x => x.Key);
            while (GroupByMultipleKeysMS.Any()) 
            {
                foreach (var group in GroupByMultipleKeysMS) //find the index of duplicates and removes them
                {
                    int index = searches.FindIndex(x => x.csvDatum == group.csvDatum && x.csvPlats == group.csvPlats);
                    searches.RemoveAt(index); 
                }
            }
            return searches;
        }
    }
}