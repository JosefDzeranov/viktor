using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary3
{
    public class AngryBall : RandomSideBall
    {
        public event EventHandler BallMoved;
        Timer gravityTimer = new Timer();

        public AngryBall(Form form) : base(form)
        {
            x = form.ClientSize.Width / 5;
            y = Convert.ToInt32(form.ClientSize.Height / 1.5);
            vx = 7;
            vy = -10;
            size = 30;
            gravityTimer.Interval = 100;
            gravityTimer.Tick += GravityTimer_Tick;

        }

        private void GravityTimer_Tick(object sender, EventArgs e)
        {
            vy += 1;
            if (vy == 0 && y >= form.ClientSize.Height - size)
            {
                timer.Stop();
                gravityTimer.Stop();
            }
        }

        protected override void Go()
        {
            base.Go();
            BallMoved.Invoke(this, new EventArgs());
            gravityTimer.Start();
            if (y <= 0)
            {
                vy *= -1;
            }
            if (y >= (form.ClientSize.Height - size))
            {
                vy = Convert.ToInt32(vy * -0.7);
                vx = Convert.ToInt32(vx * 0.7);
            }
            if (x >= (form.ClientSize.Width - size))
            {
                vx *= -1;
            }
            if (x <= 0)
            {
                vx *= -1;
            }
        }

        public void Teleport(Point point)
        {
            x = point.X;
            y = point.Y;
            BallMoved.Invoke(this, new EventArgs());
        }

    }
}
