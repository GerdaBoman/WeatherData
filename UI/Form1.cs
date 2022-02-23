
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

        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFilePath.Text))
            {
                MessageBox.Show("Please select a file before you import!");
            }
            else
            {

                importMessage.Text = "Importing .csv file....";
                statusStrip1.Update();

                CsvFormatting.EFImport(textFilePath.Text);
                var timywimy = CsvImport.Date();
                var minDay = timywimy.First();
                var maxDay = timywimy.Last();
                DateTime dayCount = minDay;

                List<double> dayLenght = new();

                importMessage.Text = "Calculating days averages...";
                statusStrip1.Update();

                while (dayCount < maxDay)
                {
                    var places = CsvImport.DailyPlace(dayCount.Year, dayCount.Month, dayCount.Day);
                    var place = places.Distinct();
                    foreach (var test in place)
                    {
                        AverageImport.AverageDB(AverageCalculation.average(test, dayCount.Year, dayCount.Month, dayCount.Day, dayLenght, 3));
                    }
                    dayCount = dayCount.AddDays(1);


                }

                importMessage.Text = "";
                statusStrip1.Update();

                MessageBox.Show("Import Completed!");


            }
        }


    }
}