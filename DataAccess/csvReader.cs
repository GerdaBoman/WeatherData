using LumenWorks.Framework.IO.Csv;
using System.Data;

namespace DataAccess
{
    public class csvReader
    {
       public void reading(string connection)
        {
           List<SearchParameters> searches = filter(connection);

            // Set the path and filename variable "path", filename being MyTest.csv in this example.
            // Change SomeGuy for your username.
            string path = @"MyTest.csv";

            // Set the variable "delimiter" to ", ".
            string delimiter = ", ";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Datum" + delimiter + "Plats" + delimiter + "Temp" + delimiter + "Luftfuktighet" + delimiter + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            foreach (var search in searches)
            {
                // This text is always added, making the file longer over time
                // if it is not deleted.
                string appendText = search.csvDatum + delimiter + search.csvPlats + delimiter + search.csvTemp + delimiter + search.csvLuftFuktighet + delimiter + Environment.NewLine;
                File.AppendAllText(path, appendText);
            }
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

        }
        public List<SearchParameters> filter(string connection)
        {
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
                    csvTemp = csvTable.Rows[i][2].ToString(),
                    csvLuftFuktighet = csvTable.Rows[i][3].ToString()
                });
            }

            var GroupByMultipleKeysMS = searches.GroupBy(x => new { x.csvDatum, x.csvPlats, x.csvTemp })
                                                    .Where(g => g.Count() > 1)
                                                    .Select(x => x.Key);

            foreach (var group in GroupByMultipleKeysMS)
            {
                int index = searches.FindIndex(x => x.csvDatum == group.csvDatum && x.csvPlats == group.csvPlats);
                searches.RemoveAt(index);
            }
            return searches;
        }
    }
}
