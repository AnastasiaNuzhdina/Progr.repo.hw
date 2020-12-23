using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetValue();

            Console.WriteLine("x = " + x);

            Console.ReadKey();
        }

        static double GetValue()
        {
            return F(3, 2, 3) + F(5, 3, 5) + F(7, 4, 7);
        }
        /// <summary>
        /// Вычисление повторяющегося выражения
        /// </summary>
        /// <param name="a">Первое слагаемое числителе</param>
        /// <param name="b">второе слагаемое в числителе</param>
        /// <param name="c">степень</param>
        /// <returns></returns> 
        static double F(double a, double b, double c)
        {
            return Math.Log10(a + Math.Pow(b, c)) / (Math.Log10(b + Math.Pow(c, b)));

        }
    }
}