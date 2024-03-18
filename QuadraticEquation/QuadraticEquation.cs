using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    public class QuadraticEquation
    {
        public static (double? x1, double? x2) Solve(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                return (null, null); // Корней нет
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return (x, null); // Один корень
            }
            else
            {
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                double x1 = (-b + sqrtDiscriminant) / (2 * a);
                double x2 = (-b - sqrtDiscriminant) / (2 * a);
                return (x1, x2); // Два корня
            }
        }
    }
}
