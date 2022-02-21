using Core;
using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortOrder = System.Windows.Forms.SortOrder;

namespace UI
{
    public partial class InsidePanel : UserControl
    {

        public InsidePanel()
        {
            InitializeComponent();

            //Column headers

            resultView.View = View.Details;
            resultView.Columns.Add("Date", 70, HorizontalAlignment.Left);
            resultView.Columns.Add("Place", 40, HorizontalAlignment.Left);
            resultView.Columns.Add("Temp", 40, HorizontalAlignment.Left);
            resultView.Columns.Add("Hum", 40, HorizontalAlignment.Left);
            resultView.Columns.Add("Mold Risk", 40, HorizontalAlignment.Left);
            resultView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Initialize ListViewer

            Avg_Calucations dataCalculating = new();
            MoldCalculation mold = new();

            var timywimy = dataCalculating.date();
            var minDay = timywimy.First();
            var maxDay = timywimy.Last();
            DateTime dayCount = minDay;

            listView1.BeginUpdate();

            while (dayCount < maxDay)
            {
                var places = dataCalculating.DailyPlace(dayCount.Year, dayCount.Month, dayCount.Day);
                var place = places.Distinct();
                foreach (var test in place)
                {
                    List<double> avergageDayTemp = dataCalculating.Daily_AverageTemperature(test, dayCount.Year, dayCount.Month, dayCount.Day);
                    List<double> averageDayHum = dataCalculating.Daily_AverageHumidity(test, dayCount.Year, dayCount.Month, dayCount.Day);

                    int moldrisk = mold.moldCalc(int.Parse(Math.Round(avergageDayTemp.Average()).ToString()), int.Parse(Math.Round(averageDayHum.Average()).ToString()));

                    string avgTemp = Math.Round(avergageDayTemp.Average(), 2).ToString();
                    string avgHum = Math.Round(averageDayHum.Average(), 2).ToString();
                    string moldRisk = moldrisk.ToString();

                    ListViewItem varItem = new(new string[] { dayCount.ToString().Substring(0, 10), test, avgTemp, avgHum, moldRisk });
                    listView1.Items.Add(varItem);

                }
                dayCount = dayCount.AddDays(1);
            }
            listView1.EndUpdate();


        }

        delegate void SetListViewCallBacks(string yourtext);
        private void showButton_Click(object sender, EventArgs e)
        {

            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;


            if (insideCheckBox.Checked && !outsideCheckBox.Checked)
            {
                resultView.Items.AddRange(new ListViewItem[] { ListViewDaily.listDaily("Inne", year, month, day) });
                resultView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
            else if (!insideCheckBox.Checked && outsideCheckBox.Checked)
            {
                resultView.Items.AddRange(new ListViewItem[] { ListViewDaily.listDaily("Ute", year, month, day) });
                resultView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
            else if (!insideCheckBox.Checked && !outsideCheckBox.Checked)
            {
                MessageBox.Show("Please choose inside or outside");
            }
            else
            {
                MessageBox.Show("Please choose only one option");
            }


        }

        private void InsidePanel_Load(object sender, EventArgs e)
        {

        }

        private ColumnHeader SortingColumn = null;

        private void listView1_ColumnIndexChanged(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader new_sorting_column = listView1.Columns[e.Column];

            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                sort_order = SortOrder.Ascending;
            }
            else
            {
                if (new_sorting_column == SortingColumn)
                {
                    if (SortingColumn.Text.StartsWith("> "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    sort_order = SortOrder.Ascending;
                }

                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            SortingColumn = new_sorting_column;

            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "> " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "< " + SortingColumn.Text;
            }

            listView1.ListViewItemSorter =
            new ListViewComparer(e.Column, sort_order);

            listView1.Sort();



        }
    }

}
