using System;
using System.Drawing;

namespace BallsWindowsFormsApp
{
    class Ball
    {
        protected int x = 100;
        protected int y = 100;
        protected int vx = 10;
        protected int vy = 10;
        protected Random random = new Random();
        protected Brush brush = Brushes.Green;
        private MainForm form;
        public Ball(MainForm form)
        {
            this.form = form;
        }

        public void Show()
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(x, y, 50, 50);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        private void Go()
        {
            x += vx;
            y += vy;
        }
        
        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(x, y, 50, 50);
            graphics.FillEllipse(Brushes.White, rectangle);
        }
    }
}
