using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Длина: ");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ширина: ");
            int sideB = Convert.ToInt32(Console.ReadLine());

            int area = sideA * sideB;

            Console.WriteLine("Площадь прямоугольника: {0}", area);
            Console.ReadLine();
        }
    }
}
