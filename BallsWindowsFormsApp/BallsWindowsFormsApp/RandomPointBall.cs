using System;
using System.Drawing;

namespace BallsWindowsFormsApp
{
    class RandomPointBall : Ball
    {
        public RandomPointBall(MainForm form) : base(form)
        {
            x = random.Next(0, 500);
            y = random.Next(0, 500);
            brush = Brushes.Red;
        }
    }
}
