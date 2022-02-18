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
            homePanel3.BringToFront();
           
        }
        

        private void homeButton_Click(object sender, EventArgs e)
        {
            homePanel3.Show();
            homePanel3.BringToFront();
        }

        private void insideButton_Click(object sender, EventArgs e)
        {
            insidePanel2.Show();
            insidePanel2.BringToFront();
        }

    

        private void floorPlanButton_Click(object sender, EventArgs e)
        {
            floorPlanPanel3.Show();
            floorPlanPanel3.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}