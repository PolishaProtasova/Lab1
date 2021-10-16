using lab1_15.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15.Protasova
{
    class Quadratic : Linear, EquationInterface
    {
        protected float Dis(float a, float b, float c)
        {
            return (float)(Math.Pow(b, 2) - (4 * a * c));
        }

        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
                return new List<float> { Convert.ToSingle(LinearEquation(a, b)) };

            float dis = Dis(a, b, c);
            if (dis < 0)
                return null;

            if (dis == 0)
                return new List<float> { -b / (2 * a) };

            x = new float[] { (float)(-b + Math.Sqrt(dis)) / (2 * a), (float)(-b - Math.Sqrt(dis)) / (2 * a) };
            return new List<float> { Convert.ToSingle(x) };
        }
    }
}
