using System;

namespace task_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var krater = "кратер";
            string kater = krater.Substring(0, 1) + krater.Substring(2, 1) + krater.Substring(3, 1) + krater.Substring(4, 1) + krater.Substring(5, 1);
            string reka = krater.Substring(1, 1) + krater.Substring(4, 1) + krater.Substring(0, 1) + krater.Substring(2, 1);
            Console.WriteLine($"Результат: {kater}, {reka}.");
            Console.ReadKey();
        }
    }
}
