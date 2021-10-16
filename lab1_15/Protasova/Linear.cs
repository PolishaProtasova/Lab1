using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15.Protasova
{
    class Linear
    {
        protected float[] x;

        public float[] LinearEquation(float a, float b)
        {
            if (a == 0)
                return null;

            return x = new float[] { -b / a };
        }
    }
}
