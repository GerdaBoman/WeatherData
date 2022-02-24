
using Core;
using DataAccess;
using DataAccess.Models;

namespace UI
{
    public partial class InsideForm : Form
    {
        public InsideForm()
        {
            InitializeComponent();

        }


        private delegate void SetListViewCallBacks(string yourtext);

        private void ShowButton_Click(object sender, EventArgs e)
        {
            List<double> dayLenght = new();
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;

            if (insideCheckBox.Checked && !outsideCheckBox.Checked)
            {
                WeatherAverage weatherAverage = AverageCalculation.average("Inne", year, month, day);
                ListViewItem AvgDataRow = new();
                AvgDataRow = new(weatherAverage.Date.ToString().Substring(5, 5));
                AvgDataRow.SubItems.Add(weatherAverage.Place.ToString());
                AvgDataRow.SubItems.Add(Math.Round((decimal)weatherAverage.TempAverage, 2).ToString());
                AvgDataRow.SubItems.Add(Math.Round((decimal)weatherAverage.HumAverage, 2).ToString());
                AvgDataRow.SubItems.Add(weatherAverage.MoldRisk.ToString());
                resultView.Items.AddRange(new ListViewItem[] { AvgDataRow });
            }
            else if (!insideCheckBox.Checked && outsideCheckBox.Checked)
            {

                WeatherAverage weatherAverage = AverageCalculation.average("Ute", year, month, day);
                ListViewItem AvgDataRow = new();
                AvgDataRow = new(weatherAverage.Date.ToString().Substring(5, 5));
                AvgDataRow.SubItems.Add(weatherAverage.Place.ToString());
                AvgDataRow.SubItems.Add(Math.Round((decimal)weatherAverage.TempAverage, 2).ToString());
                AvgDataRow.SubItems.Add(Math.Round((decimal)weatherAverage.HumAverage, 2).ToString());
                AvgDataRow.SubItems.Add(weatherAverage.MoldRisk.ToString());
                resultView.Items.AddRange(new ListViewItem[] { AvgDataRow });
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
                {
                    frm.Show();
                    return;
                }
            }
        }

        private void WeatherDataButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private ColumnHeader SortingColumn = null;

        private void ListViewer_SelectedIndexChanged(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader new_sorting_column = ListViewer.Columns[e.Column];

            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                sort_order = SortOrder.Ascending;
            }
            else
            {
                if (new_sorting_column == SortingColumn)
                {
                    if (SortingColumn.Text.StartsWith("↑ "))
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
                SortingColumn.Text = "↑ " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "↓ " + SortingColumn.Text;
            }

            ListViewer.ListViewItemSorter =
            new ListViewComparer(e.Column, sort_order);

            ListViewer.Sort();
        }

        private void InsideForm_Load(object sender, EventArgs e)
        {
            switch (CsvImport.DataExist())
            {
                case true:
                    {
                        var averageList = CsvImport.OutputAverage();
                        foreach (var item in averageList)
                        {

                            ListViewItem AvgDataRow = new();


                            AvgDataRow = new(item.Date.ToString().Substring(5, 5));
                            AvgDataRow.SubItems.Add(item.Place.ToString());
                            AvgDataRow.SubItems.Add(Math.Round((decimal)item.TempAverage, 2).ToString());
                            AvgDataRow.SubItems.Add(Math.Round((decimal)item.HumAverage, 2).ToString());
                            AvgDataRow.SubItems.Add(item.MoldRisk.ToString());

                            ListViewer.Items.AddRange(new ListViewItem[] { AvgDataRow });
                        }

                        ListViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
                        break;
                    }
                case false:
                    {
                        break;
                    }
            }

            MeteorologicalAutumn autumn = new();
            string autumDate = autumn.OfficialAutumnDay();
            autumnResults.Text = autumDate;

            MeteorologicalWinter winter = new();
            string winterDay = winter.OfficialWinterDay();
            winterResultsLabel.Text = winterDay;


        }


    }
}