using System.Drawing;

namespace BallsWindowsFormsApp
{
    class Ball
    {
        public Ball(MainForm form)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(100, 100, 50, 50);
            graphics.FillEllipse(Brushes.Green, rectangle);
        }
    }
}
