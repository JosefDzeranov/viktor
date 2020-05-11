using System.Drawing;

namespace BallsWindowsFormsApp
{
    class PointBall : Ball
    {
        public PointBall(MainForm form, int x, int y) : base(form)
        {
            base.x = x - 50 / 2;
            base.y = y - 50 / 2;
            brush = Brushes.Yellow;
        }
    }
}
