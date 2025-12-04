using System.Drawing.Drawing2D;

namespace ARC_13_Task_Performance_1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
