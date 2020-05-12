using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsWindowsFormsApp
{
    class RandomSideBall : RandomPointBall
    {
        public RandomSideBall(MainForm form) : base(form)
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
        }
    }
}
