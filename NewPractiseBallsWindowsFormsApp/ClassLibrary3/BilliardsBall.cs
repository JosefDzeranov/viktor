using System;
using System.Windows.Forms;

namespace NewPractiseBallsWindowsFormsApp
{
    public class BilliardsBall : RandomSideBall
    {
        public event EventHandler<TouchFormEvenArgs> OnTouchSide;
        public BilliardsBall(Form form) : base(form)
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
        }

        protected override void Go()
        {
            base.Go();
            if (y <= 0)
            {
                vy *= -1;
                OnTouchSide.Invoke(this, new TouchFormEvenArgs(Side.Top));
            }
            if (y >= (form.ClientSize.Height - size))
            {
                vy *= -1;
                OnTouchSide.Invoke(this, new TouchFormEvenArgs(Side.Down));
            }
            if (x >= (form.ClientSize.Width - size))
            {
                vx *= -1;
                OnTouchSide.Invoke(this, new TouchFormEvenArgs(Side.Right));
            }
            if (x <= 0)
            {
                vx *= -1;
                OnTouchSide.Invoke(this, new TouchFormEvenArgs(Side.Left));
            }
        }
    }
}
