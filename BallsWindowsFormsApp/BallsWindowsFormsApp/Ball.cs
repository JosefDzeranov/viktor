using System;
using System.Drawing;

namespace BallsWindowsFormsApp
{
    class Ball
    {
        public int X = 100;
        public int Y = 100;
        public Brush Brush = Brushes.Green;
        public MainForm Form;
        public Ball(MainForm form)
        {
            Form = form;
        }

        public void Show()
        {
            var graphics = Form.CreateGraphics();
            var rectangle = new Rectangle(X, Y, 50, 50);
            graphics.FillEllipse(Brush, rectangle);
        }
    }

    class RandomPointBall : Ball
    {
        public RandomPointBall(MainForm form) : base(form)
        {
            var random = new Random();
            X = random.Next(0, 500);
            Y = random.Next(0, 500);
            Brush = Brushes.Red;
        }
    }

    class PointBall : Ball
    {
        public PointBall(MainForm form, int x, int y) : base(form)
        {
            X = x - 50 / 2;
            Y = y - 50 / 2;
            Brush = Brushes.Yellow;
        }
    }
}
