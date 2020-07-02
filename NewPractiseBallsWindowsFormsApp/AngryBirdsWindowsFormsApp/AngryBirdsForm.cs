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
        bool canMove = false;
        public AngryBirdsForm()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            ball.Start();
        }

        private void Ball_BallMoved(object sender, EventArgs e)
        {
            pictureBox2.Location = ball.Location;
        }

        private void AngryBirdsForm_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            ball = new AngryBall(this);
            ball.Show();
            ball.BallMoved += Ball_BallMoved;
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove)
            {
                ball.Teleport(e.Location);
            }
            
        }
    }
}
