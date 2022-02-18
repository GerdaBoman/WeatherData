using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DataAccess.Data;
using Microsoft.Data.SqlClient;
using DataAccess;
using LumenWorks.Framework.IO.Csv;
using DataAccess.Models;

namespace UI
{
    public partial class HomePanel : UserControl
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
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

        private void importButton_Click(object sender, EventArgs e)
        {
            

            ImportData.ImportFile(textFilePath.Text);
           



        }
        
    }
}
