using System;
using System.Windows.Forms;
using System.Drawing;

namespace NewPractiseBallsWindowsFormsApp
{
    public class Ball 
    {
        protected static Random random = new Random();
        protected int x = 250;
        protected int y = 250;
        protected int vx = 10;
        protected int vy = 10;
        protected Brush brush = Brushes.Red;
        protected readonly Form form;
        protected readonly Timer timer = new Timer();
        private Rectangle rectangle;
        protected readonly int size;
        protected readonly double radius;
       
        public Ball(Form form)
        {
            this.form = form;
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            size = 50;
            radius = size / 2;
        }
       
        public void Show()
        {
            Graphics graphics = form.CreateGraphics();
            rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
        protected virtual void Go()
        {
            x += vx;
            y += vy;
        }
        private void Clear()
        {
            var graphics = form.CreateGraphics();
            SolidBrush solidBrush = new SolidBrush(form.BackColor);
            graphics.FillEllipse(solidBrush, rectangle);
        }
        private void Move()
        {
            Clear();
            Go();
            Show();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void StopMoving()
        {
            timer.Stop();
        }
        public void Start()
        {
            timer.Start();
        }
        public bool ClickCheck(Point location)
        {
            return Math.Pow(location.X - x - radius, 2) + Math.Pow(location.Y - y - radius, 2) <= Math.Pow(size, 2);
        }
        public bool OnScreen()
        {
            return x < form.ClientSize.Width - size && y < form.ClientSize.Height - size && x > 0 && y > 0;
        }
        public bool IsBallActive()
        {
            return timer.Enabled;
        }
       
    }
}
