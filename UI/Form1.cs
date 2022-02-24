
using Core;
using DataAccess;

using DataAccess.Data;

namespace UI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            var _context = new RoboGenderContext();
            _context.Database.EnsureCreated();


            InitializeComponent();

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void InsideButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is InsideForm)
                {
                    frm.Show();
                    return;
                }
            }

            InsideForm f2 = new();
            f2.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Title = "Select File",
                FileName = textFilePath.Text,
                Filter = "Excel Sheets (*.csv)|*.csv|All files(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textFilePath.Text = openFileDialog.FileName;
            }
            else
            {
                textFilePath.Text = null;
            }
        }

        private async void ImportButton_Click(object sender, EventArgs e)
        {
            AverageImport averageImport = new();
            CsvFormatting csvFormatting = new();
            AverageCalculation average = new();
            if (String.IsNullOrEmpty(textFilePath.Text))
            {
                MessageBox.Show("Please select a file before you import!");
            }
            else
            {

                importMessage.Text = "Importing .csv file....";
                statusStrip1.Update();

                csvFormatting.EFImport(textFilePath.Text);
                var timywimy = CsvImport.Date();
                var minDay = timywimy.First();
                var maxDay = timywimy.Last();


                importMessage.Text = "Calculating days averages...";
                statusStrip1.Update();

                while (minDay < maxDay)
                {
                    var places = CsvImport.DailyPlace(minDay.Year, minDay.Month, minDay.Day).Distinct();


                    foreach (var test in places)
                    {
                        averageImport.AverageDB(average.average(test, minDay.Year, minDay.Month, minDay.Day));
                    }


                    minDay = minDay.AddDays(1);

                }

                importMessage.Text = "";
                statusStrip1.Update();

                MessageBox.Show("Import Completed!");


            }
        }


    }
}