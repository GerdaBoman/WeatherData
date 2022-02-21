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
        public bool listvieInitialize = ImportData.DataExsist();
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

            

        }



        private void Reveal_Click(object sender, EventArgs e)
        {
            switch (listvieInitialize)
            {
                case true:
                    {

                        var timywimy = Avg_Calucations.date();
                        var minDay = timywimy.First();
                        var maxDay = timywimy.Last();
                        DateTime dayCount = minDay;

                        listView1.BeginUpdate();



                        while (dayCount < maxDay)
                        {
                            var places = Avg_Calucations.DailyPlace(dayCount.Year, dayCount.Month, dayCount.Day);
                            var place = places.Distinct();
                            foreach (var test in place)
                            {
                                listView1.Items.AddRange(new ListViewItem[] { ListViewDaily.listDaily(test, dayCount.Year, dayCount.Month, dayCount.Day) });
                                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                int etst = places.Distinct().Count();
                            }
                            dayCount = dayCount.AddDays(1);
                        }
                        listView1.EndUpdate();

                        break;
                    }
                case false:
                    {
                        break;
                    }
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
    }

}
