using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = -11;
            double c = 5;

            var result = QuadraticEquation.Solve(a, b, c);

            if (result.x1.HasValue && result.x2.HasValue)
            {
                Console.WriteLine($"Корни уравнения: x1 = {result.x1}, x2 = {result.x2}");
            }
            else if (result.x1.HasValue)
            {
                Console.WriteLine($"Уравнение имеет один корень: x = {result.x1}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней.");
            }
            Console.ReadKey();
        }
    }
}
