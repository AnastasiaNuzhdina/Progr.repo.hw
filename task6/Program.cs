using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, позицию белого ферзя");
            var whiteQueenPosition = Console.ReadLine();
            Console.WriteLine("Введите, позицию чёрной слона");
            var blackBishopPosition = Console.ReadLine();

            if (CheckPosition(whiteQueenPosition, blackBishopPosition))
            {
                Console.WriteLine("Введите ход белого ферзя");
                var whiteQueenMove = Console.ReadLine();
                if (CanQueenMakeSafeMove(whiteQueenMove, whiteQueenMove, blackBishopPosition))
                    Console.WriteLine("Ферзь может ходить");
                else
                    Console.WriteLine("Ферзь не может ходить");
            }
            else
                Console.WriteLine("Начальная расстановка фигур неверна");

            Console.ReadKey();
        }

        static void GetCoordinates(string position, out int x, out int y)
        {
            x = (int)position[0] - 0x60;
            y = int.Parse(position[1].ToString());
        }

        //Queen and Bishop

        static bool CanQueenMakeMove(string start, string end)
        {
            if (start == end)
                return false;

            int startX, startY, endX, endY;

            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return Math.Abs(endX - startX) <= 1 && Math.Abs(endY - startY) <= 1;
        }

        static bool CanBishopMakeMove(string start, string end)
        {
            if (start == end)
                return false;

            int startX, startY, endX, endY;

            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return startX == endX || startY == endY;
        }

        static bool CheckPosition(string whitePosition, string blackPosition)
        {
            return whitePosition != blackPosition && !CanQueenMakeMove(whitePosition, blackPosition) && !CanBishopMakeMove(blackPosition, whitePosition);
        }

        static bool CanQueenMakeSafeMove(string QueenStartPosition, string QueenNewPosition, string BishopPosition)
        {
            return CanQueenMakeMove(QueenStartPosition, QueenNewPosition) && !CanBishopMakeMove(BishopPosition, QueenNewPosition);
        }
    }
}