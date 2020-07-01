using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
    public partial class AngryBirdsForm : Form
    {
        AngryBall ball;
        public AngryBirdsForm()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            ball = new AngryBall(this);
            ball.Show();
            ball.Start();
            ball.BallMoved += Ball_BallMoved;
        }

        private void Ball_BallMoved(object sender, EventArgs e)
        {
            pictureBox2.Location = ball.Location;
        }

        private void AngryBirdsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
