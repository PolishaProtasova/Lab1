using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15.Protasova
{
    class Linear
    {
        protected List<float> x;

        public List<float> LinearEquation(float b, float c)
        {
            if (b == 0)
            {
                throw new ProtasovaException("Уравнение не существует");
            }

            return x = new List<float> { -b / c };
        }
    }
}
