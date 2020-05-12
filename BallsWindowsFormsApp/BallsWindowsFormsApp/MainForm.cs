using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<RandomSideBall> balls;

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
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Move();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            balls = new List<RandomSideBall>();
            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomSideBall(this);
                ball.Show();
                balls.Add(ball);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
