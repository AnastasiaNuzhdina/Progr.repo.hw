using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, f;
            Console.WriteLine("Введите значение x:");
            x = double.Parse(Console.ReadLine());

            if (Math.Sin(x) > 0)
            {
                f = Math.Cos(x);
                Console.WriteLine("Значение функции F(x):" + f);
            }
            else
                if (Math.Sin(x) == 0)
            {
                f = Math.PI / 2;
                Console.WriteLine("Значение функции F(x):" + f);
            }
            else
                if (Math.Sin(x) < 0)
            {
                f = -Math.Cos(x);
                Console.WriteLine("Значение функции F(x):" + f);
            }
            Console.ReadKey();
        }




    }
}