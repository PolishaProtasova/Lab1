using lab1_15.Protasova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProtasovaLog.I().Write("Введите три параметра: a, b, c");

                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());

                if (a == 0)
                    ProtasovaLog.I().Write("Введенное уравнение: " + b + "x" + "+" + c + "=0");
                else
                    ProtasovaLog.I().Write("Введенное уравнение: " + a + "x^2" + "+" + b + "x" + "+" + c + "=0");

                Quadratic uravnenie = new Quadratic();
                List<float> arr = uravnenie.Solve(a, b, c);
                ProtasovaLog.I().Log("Корни уравнения: " + string.Join(" ", arr));
            }

            catch (ProtasovaException e)
            {
                ProtasovaLog.I().Log(e.Message);
            }

            ProtasovaLog.I().Write();
            Console.ReadKey();
        }
    }
}
