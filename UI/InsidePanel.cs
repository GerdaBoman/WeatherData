using Core;
using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class InsidePanel : UserControl
    {

        public InsidePanel()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("Date", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Place", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("Temp", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("Hum", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("Mold Risk", 40, HorizontalAlignment.Left);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }


        private void showButton_Click(object sender, EventArgs e)
        {
            MoldCalcuation mold = new();
            DateTime dateTime = dateTimePicker1.Value;

            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;
            Avg_Calucations dataCalculating = new Avg_Calucations();


            var timywimy = dataCalculating.date();
            var minDay = timywimy.First();
            var maxDay = timywimy.Last();
            DateTime dayCount = minDay;
            int i = 1;
            while (dayCount < maxDay)
            {
                var places = dataCalculating.DailyPlace(dayCount.Year, dayCount.Month, dayCount.Day);
                var place = places.Distinct();
                foreach (var test in place)
                {
                    List<double> avergageDayTemp = dataCalculating.Daily_AverageTemperature(test, dayCount.Year, dayCount.Month, dayCount.Day);
                    List<double> averageDayHum = dataCalculating.Daily_AverageHumidity(test, dayCount.Year, dayCount.Month, dayCount.Day);
                    ListViewItem item1 = new ListViewItem(dayCount.ToString().Substring(0, 10));

                    int moldrisk = mold.moldCalc(int.Parse(Math.Round(avergageDayTemp.Average()).ToString()), int.Parse(Math.Round(averageDayHum.Average()).ToString()));

                    item1.SubItems.Add(test);
                    item1.SubItems.Add(Math.Round(avergageDayTemp.Average(), 2).ToString());
                    item1.SubItems.Add(Math.Round(averageDayHum.Average(), 2).ToString());
                    item1.SubItems.Add(moldrisk.ToString());

                    listView1.Items.AddRange(new ListViewItem[] { item1 });
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    int etst = places.Distinct().Count();
              
                }
                dayCount = dayCount.AddDays(1);
            }
            //if (insideCheckBox.Checked && !outsideCheckBox.Checked)
            //{
            //    List<double> avergageDayTemp = dataCalculating.Daily_AverageTemperature("Inne", year, month, day);
            //    List<double> averageDayHum = dataCalculating.Daily_AverageHumidity("Inne", year, month, day);
            //    ListViewItem item1 = new ListViewItem(dateTime.ToString().Substring(0, 10));

            //    int moldrisk = mold.moldCalc(int.Parse(Math.Round(avergageDayTemp.Average()).ToString()), int.Parse(Math.Round(averageDayHum.Average()).ToString()));

            //    item1.SubItems.Add("Inne");
            //    item1.SubItems.Add(Math.Round(avergageDayTemp.Average(), 2).ToString());
            //    item1.SubItems.Add(Math.Round(averageDayHum.Average(), 2).ToString());
            //    item1.SubItems.Add(moldrisk.ToString());

            //    listView1.Items.AddRange(new ListViewItem[] { item1 });
            //    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //}
            //else if (!insideCheckBox.Checked && outsideCheckBox.Checked)
            //{
            //    List<double> avergageDayTemp = dataCalculating.Daily_AverageTemperature("Ute", year, month, day);
            //    List<double> averageDayHum = dataCalculating.Daily_AverageHumidity("Ute", year, month, day);
            //    ListViewItem item1 = new ListViewItem(dateTime.ToString().Substring(0, 10));

            //    int moldrisk = mold.moldCalc(int.Parse(Math.Round(avergageDayTemp.Average()).ToString()), int.Parse(Math.Round(averageDayHum.Average()).ToString()));

            //    item1.SubItems.Add("Ute");
            //    item1.SubItems.Add(Math.Round(avergageDayTemp.Average(), 2).ToString());
            //    item1.SubItems.Add(Math.Round(averageDayHum.Average(), 2).ToString());
            //    item1.SubItems.Add(moldrisk.ToString());

            //    listView1.Items.AddRange(new ListViewItem[] { item1 });
            //    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //}
            //else if(!insideCheckBox.Checked && !outsideCheckBox.Checked)
            //{
            //    MessageBox.Show("Please choose inside or outside");
            //}
            //else
            //{
            //    MessageBox.Show("Please choose only one");
            //}


        }


    }
}
