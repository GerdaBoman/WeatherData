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
            listView1.GridLines = true;

            
            DateTime dateTime = dateTimePicker1.Value;

     




            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;

            DataSending dataSending = new DataSending();
            IList<object> Gridview = new List<object>();

            List<double> avergageDayTemp = dataSending.Daily_Average("Inne", year, month, day);


            List<double> averageDayHum = dataSending.Daily_AverageHum("Inne", year, month, day);
            string test = ($"{dateTime}     Inne        {Math.Round(avergageDayTemp.Average(),2)}         {Math.Round(averageDayHum.Average(),2)}");
            listBox.Items.Add(test);
            ListViewItem Item1 = new ListViewItem("item 1",0);
            Item1.SubItems.Add("1");
            Item1.SubItems.Add("2");
            Item1.SubItems.Add("3");
            Item1.SubItems.Add("4");
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            listView1.Items.AddRange(new ListViewItem[] { Item1 });
            List<DateTime> dateList = new List<DateTime>();
            dateList.Add(DateTime.Now);
            dateList.Add(dateTime);

           
            //TODO:
        }

        
    }
}
 