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
        }
    }
}
