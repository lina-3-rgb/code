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
            double y = Convert.ToDouble(Console.ReadLine());
            double s = Math.Pow((y * Math.Pow(x, 2) - 1), 2) / (2) * (Math.Pow(Math.Cos(y), 2) - Math.Sin(Math.Pow(x,2)));
            Console.WriteLine("Ответ:" + s);
        }
    }
}