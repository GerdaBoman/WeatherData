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
            
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Weather", "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = RoboGender; Integrated Security = True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Weather");
            dataGridView1.DataSource = ds.Tables["Weather"].DefaultView;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            listBox.MultiColumn = true;

            DateTime dateTime = dateTimePicker1.Value;

     




            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;

            DataSending dataSending = new DataSending();
            IList<object> Gridview = new List<object>();

            List<double> avergageDayTemp = dataSending.Daily_Average("Inne", year, month, day);


            List<double> averageDayHum = dataSending.Daily_AverageHum("Inne", year, month, day);
            string test = ($"{dateTime}     Inne        {Math.Round(avergageDayTemp.Average())}         {Math.Round(averageDayHum.Average())}");
            listBox.Items.Add(test);
            //Gridview.Add(new GridImport {Date = dateTime, Location = "Inne", Temperature = avergageDayTemp.Average(), Humidity = averageDayHum.Average()});

            //listBox.DataSource = Gridview;
        }
    }
}
 