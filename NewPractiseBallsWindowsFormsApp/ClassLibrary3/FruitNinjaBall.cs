﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary3
{
    public class FruitNinjaBall : RandomSideBall
    {
        public bool Active => timer.Enabled;

        public bool WasEvent { get; protected set; }
        protected  Timer timerForRising = new Timer();
        public event EventHandler<BallDisapearedEventArgs> BallGoneAway;
        public event EventHandler<BallDisapearedEventArgs> BallMouseCought;
        private int gravity = 1;
        readonly double screenPart = random.Next(1,10) + 0.5;
        protected bool IsFalling => vy >= 1;
        public FruitNinjaBall(Form form) : base(form)
        {
            Y = form.ClientSize.Height;
            vy = random.Next(-5, 0);
            vx = random.Next(-1, 1);
            SlowerBall();
            WasEvent = false;
        }
        private void SlowerBall()
        {
            timerForRising.Interval = 20;
            timerForRising.Tick += TimerForRising_Tick;
            timerForRising.Start();
        }
        protected virtual void TimerForRising_Tick(object sender, EventArgs e)
        {
            if (vy <= 2 && Y < form.ClientSize.Height/screenPart)
            {
                vy += gravity;
            }
            if (!OnScreen() && IsFalling ) 
            {
                BallGoneAway.Invoke(this, new BallDisapearedEventArgs(this));
                WasEvent = true;
            }
        }
        public void BallCought(FruitNinjaBall ball)
        {
            BallMouseCought.Invoke(ball, new BallDisapearedEventArgs(ball));
            WasEvent = true;
            StopMoving();
            Clear();
        }
    }
}
