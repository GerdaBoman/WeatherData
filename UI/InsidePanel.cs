using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
