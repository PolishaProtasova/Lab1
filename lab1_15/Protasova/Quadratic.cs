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
            {
                ProtasovaLog.I().Log("Уравнение является линейным");
                return LinearEquation(b, c);
            }

            float dis = Dis(a, b, c);
            ProtasovaLog.I().Log("Уравнение является квадратным");

            if (dis < 0)
            {
                throw new ProtasovaException("Уравнение не имеет решений");
            }
            if (dis == 0)
            {
                return x = new List<float> { -b / (2 * a) };
            }

            return x = new List<float> { (float)(-b + Math.Sqrt(dis)) / (2 * a), (float)(-b - Math.Sqrt(dis)) / (2 * a) };
        }
    }
}
