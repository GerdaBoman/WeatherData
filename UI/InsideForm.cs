using Core;
using DataAccess;
using System.Collections;

namespace UI
{
    public partial class InsideForm : Form
    {
        public bool listvieInitialize = ImportData.DataExsist();

        public InsideForm()
        {
            InitializeComponent();

            resultView.View = View.Details;
            resultView.Columns.Add("Date", 70, HorizontalAlignment.Left);
            resultView.Columns.Add("Place", 40, HorizontalAlignment.Left);
            resultView.Columns.Add("Temp", 40, HorizontalAlignment.Left);
            resultView.Columns.Add("Hum", 40, HorizontalAlignment.Left);
            resultView.Columns.Add("Mold Risk", 40, HorizontalAlignment.Left);
            resultView.Columns.Add("Season", 40, HorizontalAlignment.Left);

            resultView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

                        updateMessageStrip.Text = "Updating Data List....";
                        statusStripInside.Update();

                        listView1.BeginUpdate();


                        List<double> dayLenght = new();

                        while (dayCount < maxDay)
                        {
                            var places = Avg_Calucations.DailyPlace(dayCount.Year, dayCount.Month, dayCount.Day);
                            var place = places.Distinct();
                            foreach (var test in place)
                            {
                                listView1.Items.AddRange(new ListViewItem[] { ListViewDaily.listDaily(test, dayCount.Year, dayCount.Month, dayCount.Day,dayLenght,3) });
                                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                int etst = places.Distinct().Count();
                            }
                            dayCount = dayCount.AddDays(1);
                        }
                        listView1.EndUpdate();

                        updateMessageStrip.Text = "";
                        statusStripInside.Update();

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
            List<double> dayLenght = new ();
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;


            if (insideCheckBox.Checked && !outsideCheckBox.Checked)
            {
                resultView.Items.AddRange(new ListViewItem[] { ListViewDaily.listDaily("Inne", year, month, day,dayLenght,3) });
                resultView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
            else if (!insideCheckBox.Checked && outsideCheckBox.Checked)
            {
                resultView.Items.AddRange(new ListViewItem[] { ListViewDaily.listDaily("Ute", year, month, day,dayLenght,3) });
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

        private void homeButton_Click(object sender, EventArgs e)
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private ColumnHeader SortingColumn = null;

        private void listView1_SelectedIndexChanged(object sender, ColumnClickEventArgs e)
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

            listView1.ListViewItemSorter =
            new ListViewComparer(e.Column, sort_order);

            listView1.Sort();
        }

        

        
    }
}
