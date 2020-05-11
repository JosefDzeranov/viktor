using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            var rectangle = new Rectangle(0, 0, 50, 50);
            graphics.DrawRectangle(Pens.Red, rectangle);
            graphics.FillEllipse(Brushes.Black, rectangle);
        }
    }
}
