using System;
using System.Windows.Forms;

namespace BallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        RandomSideBall ball;

        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ball = new RandomSideBall(this, e.X, e.Y);
            ball.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ball.Move();
        }
    }
}
