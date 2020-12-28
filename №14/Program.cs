using System;
using System.Collections.Generic;
using System.Text;

namespace _14
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите сообщение");
            string UserString = Console.ReadLine().ToLower();// принимает значение прописными буквами
            Console.WriteLine("Зашифрованное сообщение: ");

            List<char> initialKey = new List<char>(); // создание нового списка (единственный формат данных куда можно добавлять новые элементы(строка и массив нельзя))


            for (int i = 0; i < UserString.Length; i++) // для каждой ячейки в строке
            {
                Random r = new Random(); //
                int rInt = r.Next(0, 64);//генерация случайного числа от 0 до 64
                initialKey.Add(Generator(rInt));// добавить в список символ в позиции rInt на строке в методе генератора
                Encryptor(UserString[i], Generator(rInt));// отправить в метод encryptor символ строки пользователя и символ ключа
            }
            Console.WriteLine("\nСгенерированный ключ: ");
            for (int i = 0; i < initialKey.Count; i++)//распечатать ключ
            {
                Console.Write(initialKey[i]);// распечатать символ i из ключа
            }




            Console.WriteLine("\n\nВведите ключ для расшифровки");
            string myKey = Console.ReadLine();


            Console.WriteLine("\nВведите зашифрованное сообщене");
            UserString = Console.ReadLine();// меняет свое значение на ввод

            for (int i = 0; i < UserString.Length; i++)
            {
                char tempkey = myKey[i];// взять i-тый элем. из ключа
                Decryptor(UserString[i], tempkey);// отправить в decryptor символ из троки и символ из ключа
            }









        }

        static char Generator(int RandomInt)//преобразовывает число от нуля до 64 в символ
        {
            string myString = "0123456789abcdefghijklmnopqrstuvwxyz []|{}$%^*()<>_+:;/?&.,`~'@#!";
            return myString[RandomInt];
        }
        static void Encryptor(char InputChar, char keychar)//шифрует символ сообщения символом ключа
        {
            string myString = "0123456789abcdefghijklmnopqrstuvwxyz []|{}$%^*()<>_+:;/?&.,`~'@#!";
            Console.Write(myString[((myString.IndexOf(InputChar) + myString.IndexOf(keychar)) % (myString.Length))]);
        }
        static void Decryptor(char InputChar, char keychar)// расшифровывает символ сообщения символом ключа 
        {
            string myString = "0123456789abcdefghijklmnopqrstuvwxyz []|{}$%^*()<>_+:;/?&.,`~'@#!";
            Console.Write(myString[((myString.IndexOf(InputChar) - myString.IndexOf(keychar) + myString.Length) % (myString.Length))]);
        }

    }
}


