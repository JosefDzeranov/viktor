using System;

namespace NewPractiseBallsWindowsFormsApp
{
    public class TouchFormEvenArgs : EventArgs
    {
        public Side Side { get; }
        public TouchFormEvenArgs(Side side)
        {
            Side = side;
        }
    }
}
