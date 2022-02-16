using DataAccess;
using DataAccess.Data;
using DataAccess.Models;
using LumenWorks.Framework.IO.Csv;
using System.Data;

var csvTable = new DataTable();
using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(@"C:\TempFuktData.csv")), true))
{
    csvTable.Load(csvReader);
}
List<SearchParameters> searches = new List<SearchParameters>();

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
using (var context = new RoboGenderContext())
{
    foreach (var se in searches)
    {

        var weather = new Weather
        {
            Datum = DateTime.Parse(se.csvDatum),
            Plats = se.csvPlats.ToString(),
            Temp = double.Parse(se.csvTemp.Replace('.', ',')),
            Luftfuktighet = double.Parse(se.csvLuftFuktighet.Replace('.', ','))
        };
        context.Weathers.Add(weather);
        context.SaveChanges();
    }

}