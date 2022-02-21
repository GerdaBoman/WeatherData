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
        

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
               
        }

        private void insideButton_Click(object sender, EventArgs e)
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

            InsideForm f2 = new InsideForm();
            f2.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            InsideForm inside = new InsideForm();
            importMessageBar.Text = "Importing .csv file....";
            statusStrip1.Update();

            ImportData.ImportFile(textFilePath.Text);
            inside.listvieInitialize = true;
            MessageBox.Show("ImportCompleted!");

            importMessageStatusBar.Text = "";
            statusStrip1.Update();
        }
    }
}