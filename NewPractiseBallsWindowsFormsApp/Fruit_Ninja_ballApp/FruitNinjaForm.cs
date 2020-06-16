﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3;

namespace Fruit_Ninja_ballApp
{
    public partial class FruitNinjaForm : Form
    {
        FruitNinjaBall ball;
        
        public FruitNinjaForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ball = new FruitNinjaBall(this);
            ball.Show();
            ball.Start();
        }
    }
}
