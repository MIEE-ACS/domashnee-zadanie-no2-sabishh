using System;

namespace SABDZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" шаг");
            double shag = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус");
            double R = double.Parse(Console.ReadLine());
            for (double x1 = -4; x1 <= 10; x1 = x1 + shag)
            {
                find(x1, R);
            }
           
                Console.WriteLine("Введите значение X :");
                double X = double.Parse(Console.ReadLine());
            find(X, R);
        }

        private static void find(double x, double R)
        {
            double y = 0;
            if (Math.Round(x, 2) >= -4 && x <= -2)
            {
                y = x+3;
                Console.WriteLine($" Y:{string.Format("{0:0.000}", y)}");
            }
            if (x > -2 && x <= 4)
            {
                y = -x / 2;
                Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");
            }
            if (x > 4 && x <= 6)
            {
                y = -2;
                Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");
            }
            if (Math.Round(R, 3) < 2)
            {
                if (x > 6 && x < 8 - R)
                {
                    Console.WriteLine(" y не существует");
                }
                if (x > 8 + R && x < 10)
                {  
                    Console.WriteLine(" y не существует");
                  
                }
                if (Math.Round(x, 3) >= 8 - R && Math.Round(x, 3) <= 8 + R)
                {

                    y = Math.Sqrt(Math.Abs(R * R - (x -8) * (x -8)));
                    Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");

                }
            }
            if (Math.Round(R, 3) >= 2)
            {
                if (Math.Round(x, 3) >= 6 && Math.Round(x, 3) <= 10)
                {

                    y = Math.Sqrt(Math.Abs(R * R - (x -8) * (x -8)));
                    Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");

                }
            }
        }
    }
}

