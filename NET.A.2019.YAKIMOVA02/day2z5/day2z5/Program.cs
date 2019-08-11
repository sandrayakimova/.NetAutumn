using System;

namespace day2z5
{
    class MainClass
    {
        public static double Newton(double n, double A, double eps)
        
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A /Math.Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));
            }

            return x1;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Newton(3,8,0.1));
        }
    }
}
