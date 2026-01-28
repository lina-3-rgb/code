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
            Console.WriteLine("Введите y:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите a:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double y = Convert.ToDouble(Console.ReadLine());
            double z;

            if (x > 0 && y > 0)
            {
                double maxEl = a / x;
                if (maxEl < b / x)
                {
                    maxEl = b / x;
                }
                if (maxEl < Math.Sqrt(y))
                {
                    maxEl = Math.Sqrt(y);
                }
                z = maxEl;
            }
            else if (x < 0 && y > 0)
            {
                double minEl = a * Math.Pow(x, 3);
                if (minEl < b * Math.Pow(y, 2))
                    minEl = b * Math.Pow(y, 2);
                z = minEl;
            }
            else z = Math.Pow(2, x + y);
            Console.WriteLine(z);

        }
    }

}
