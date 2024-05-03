using FillingStationManagementSystem.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Forms
{
    public partial class LoadingForm : Form
    {
        public Point mouseLocation;
        public LoadingForm()
        {
            InitializeComponent();

        }


        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.BLEND);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar2.Increment(2);
            LoginForm lf = new LoginForm();
            if (progressBar2.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                lf.Show();
            }
        }

        private void loadingMouseDown(object sender, MouseEventArgs e) 
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void loadingMouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) 
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation);
                Location = mousePose;
            }
        }
    }
}
