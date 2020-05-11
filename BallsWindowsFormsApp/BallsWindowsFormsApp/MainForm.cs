using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var ball = new Ball(this);
            ball.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ball = new RandomPointBall(this);
            ball.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var ball = new PointBall(this, e.X, e.Y);
            ball.Show();
        }
    }
}
