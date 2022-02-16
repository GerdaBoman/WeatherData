using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DataAccess.Data;
using Microsoft.Data.SqlClient;
using DataAccess;
using LumenWorks.Framework.IO.Csv;
using DataAccess.Models;

namespace UI
{
    public partial class HomePanel : UserControl
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.FileName = textFilePath.Text;
            openFileDialog.Filter = "Excel Sheets (*.csv)|*.csv|All files(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textFilePath.Text = openFileDialog.FileName;
            }
            else
            {
                textFilePath = null;
            }

        }

        private void importButton_Click(object sender, EventArgs e)
        {
            #region Samuels
            //var csvTable = new DataTable();
            //using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(textFilePath.Text)), true))
            //{
            //    csvTable.Load(csvReader);
            //}
            //List<SearchParameters> searches = new List<SearchParameters>();

            //for (int i = 0; i < csvTable.Rows.Count; i++)
            //{
            //    searches.Add(new SearchParameters
            //    {
            //        csvDatum = csvTable.Rows[i][0].ToString(),
            //        csvPlats = csvTable.Rows[i][1].ToString(),
            //        csvTemp = csvTable.Rows[i][2].ToString(),
            //        csvLuftFuktighet = csvTable.Rows[i][3].ToString()
            //    });
            //}
            //while (true)
            //{
            //    var GroupByMultipleKeysMS = searches.GroupBy(x => new { x.csvDatum, x.csvPlats })
            //                                            .Where(g => g.Count() > 1)
            //                                            .Select(x => x.Key);
            //    while (GroupByMultipleKeysMS.Count() > 0)
            //    {
            //        foreach (var group in GroupByMultipleKeysMS)
            //        {
            //            int index = searches.FindIndex(x => x.csvDatum == group.csvDatum && x.csvPlats == group.csvPlats);
            //            searches.RemoveAt(index);
            //        }
            //        if (searches.Count == 0)
            //        { break; }
            //    }
            //    break;
            //}
            //using (var context = new RoboGenderContext())
            //{
            //    foreach (var se in searches)
            //    {

            //        var weather = new Weather
            //        {
            //            Datum = DateTime.Parse(se.csvDatum),
            //            Plats = se.csvPlats.ToString(),
            //            Temp = double.Parse(se.csvTemp.Replace('.', ',')),
            //            Luftfuktighet = double.Parse(se.csvLuftFuktighet.Replace('.', ','))
            //        };
            //        context.Weathers.Add(weather);
            //        context.SaveChanges();
            //    }

            //}

            #endregion

            #region Gerda version

           
            
            #endregion
           

        }
        private static string GetNumbers(string input)
        {
            int index = input.IndexOf('.');

            if (index != -1)
            {

                return new string(input.Where(c => char.IsDigit(c)).ToString().Insert(index, ".").ToArray());
            }
            else
                return new string(input.Where(c => char.IsDigit(c)).ToArray());

        }
    }
}
