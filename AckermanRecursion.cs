//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

//Функция Аккермана имеет два параметра m и n и определяется следующим образом:
//A(m, n) = n + 1, если m = 0
//A(m, n) = A(m — 1, 1), если m ≠ 0 и n = 0
//A(m, n) = A(m — 1, A(m, n — 1)), если m ≠ 0 и n ≠ 0

using System;

namespace AckermanRecursion
{
    public static class Program
    {
        public static int Acker(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return Acker(m - 1, 1);
            }
            else
            {
                return Acker(m - 1, Acker(m, n - 1));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Введите число М");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Acker(m, n));
        }
    }
}
