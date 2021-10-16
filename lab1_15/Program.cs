using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15
{
    class A
    {
        protected double[] x;

        public double[] LinearEquation(double a, double b)
        {
            if (a == 0)
                return null;

            return x = new double[] { -b / a };   
        }
    }
    class B : A
    {
        protected double Dis(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;            
        }

        public double[] QuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
                return LinearEquation(a, b);

            double dis = Dis(a, b, c);
            if (dis < 0)
                return null;

            if (dis == 0)
                return x = new double[] { -b / (2 * a) };
    
            return x = new double[] { (-b + Math.Sqrt(dis)) / (2 * a) , (-b - Math.Sqrt(dis)) / (2 * a) };            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
