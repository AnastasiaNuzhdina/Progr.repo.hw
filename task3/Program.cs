using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathFunction("x"));
        }


        public static double MathFunction(string a)
        {
            Console.WriteLine("Введите число " + a);
            double x = double.Parse(Console.ReadLine());
            return Math.Abs(1 + Math.Sqrt(x + 1)) / Math.Abs(1 - Math.Sqrt(x - 1));
        }
    }
}