using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            for (double i = -3; i < 3; i += 0.25)
            {
                if (x > 2)
                {
                    x = Math.Pow(2.72, 2);
                }
                else if (i >= -2 && i <= 2)
                {
                    x = x + 4;
                }
                else
                {
                    x = 0;
                }
                Console.WriteLine("Ответ:" + x);
            }
        }
    }
}