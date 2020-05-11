using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsWindowsFormsApp
{
    class RandomSideBall : PointBall
    {
        public RandomSideBall(MainForm form, int x, int y) : base(form, x, y)
        {
            vx = random.Next(-20, 20);
            vy = random.Next(-20, 20);
        }
    }
}
