using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary3
{
    public class AngryBall : RandomSideBall
    {
        public event EventHandler BallMoved;
        public AngryBall(Form form) : base(form)
        {

        }
        protected override void Go()
        {
            base.Go();
            BallMoved.Invoke(this, new EventArgs());
        }
    }
}
