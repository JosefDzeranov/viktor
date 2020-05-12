using System;
using System.Drawing;

namespace BallsWindowsFormsApp
{
    class RandomPointBall : Ball
    {
        public RandomPointBall(MainForm form) : base(form)
        {
            x = random.Next(0, form.ClientSize.Width - 50);
            y = random.Next(0, form.ClientSize.Height - 50);
            brush = Brushes.Red;
        }
    }
}
