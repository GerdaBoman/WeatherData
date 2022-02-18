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
            homePanel2.BringToFront();
           
        }
        

        private void homeButton_Click(object sender, EventArgs e)
        {
            homePanel2.Show();
            homePanel2.BringToFront();
        }

        private void insideButton_Click(object sender, EventArgs e)
        {
            insidePanel1.Show();
            insidePanel1.BringToFront();
        }

    

        private void floorPlanButton_Click(object sender, EventArgs e)
        {
            floorPlanPanel2.Show();
            floorPlanPanel2.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rawDataButton_Click(object sender, EventArgs e)
        {
            rawDataPanel1.Show();
            rawDataPanel1.BringToFront();
        }
    }
}