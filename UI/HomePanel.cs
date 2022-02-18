
using DataAccess;

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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.FileName = textFilePath.Text;
            openFileDialog.Filter = "Excel Sheets (*.csv)|*.csv|All files(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
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
            importMessageStatusBar.Text = "Importing .csv file....";
            statusStrip1.Update();

            ImportData import = new ImportData();

            import.ImportFile(textFilePath.Text);

            MessageBox.Show("ImportCompleted!");

            importMessageStatusBar.Text = "";
            statusStrip1.Update();


        }
        
    }
}
