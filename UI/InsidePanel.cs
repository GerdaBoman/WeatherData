using Core;
using DataAccess.Data;
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
            DateTime dt = dateTimePicker1.Value;


            //SqlDataAdapter da = new SqlDataAdapter($@"SELECT MIN(Datum) AS 'Datum', Plats, AVG(Temp) AS 'Temperature', AVG(Luftfuktighet) AS 'Luftfuktighet' FROM Weather WHERE Datum Like '{dt}%' AND Plats = 'Inne' GROUP BY  Plats", "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = RoboGender; Integrated Security = True");
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Weather");
            //dataGridView1.DataSource = ds.Tables["Weather"].DefaultView;


           





        }
    }
}
 