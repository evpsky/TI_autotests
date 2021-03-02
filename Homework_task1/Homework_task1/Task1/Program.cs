using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа считает площадь квадрата и круга");


            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("\nПопытка №{0}", i + 1);
                Console.Write("Введите сторону квадрата: ");
                var sideA = double.Parse((Console.ReadLine()));
                if (sideA <= 0)
                {
                    Console.WriteLine("\nВведенное число меньше или равно нулю, введите сторону квадрата еще раз");

                }
                else if (sideA > 0)
                {
                    // S = a * 2 - площадь квадрата 
                    var square_1 = sideA * 2;
                    Console.WriteLine("Площадь прямоугольника: {0}", square_1);
                    break;
                }
                if (i > 1)
                {
                    Console.WriteLine("\nКоличество попыток закончилось. будут установлены значения по умолчанию: ");
                    // S = a * 2 - площадь квадрата 
                    var square_1 = Math.Round((GetRandomNumber(0.5, 5) * 2), 2);
                    Console.WriteLine("Площадь прямоугольника: {0}", square_1);
                }

            }


            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("\nТеперь давайте посчитаем радиус круга");
                Console.WriteLine("\nПопытка №{0}", i + 1);
                Console.Write("Введите радиус окружности: ");
                var rad = double.Parse((Console.ReadLine()));
                if (rad <= 0)
                {
                    Console.WriteLine("\nВведенное число меньше или равно нулю, введите радиус окружности еще раз");

                }
                else if (rad > 0)
                {
                    // S = 3,14 * R*2 - площадь круга
                    var square_2 = Math.Round(Math.PI * Math.Pow(rad, 2), 2);
                    Console.WriteLine("Площадь круга: {0}", square_2);
                    break;
                }
                if (i > 1)
                {
                    Console.WriteLine("Количество попыток закончилось. будут установлены значения по умолчанию: ");
                    // S = 3,14 * R*2 - площадь круга
                    var square_3 = Math.Round(Math.PI * Math.Pow(GetRandomNumber(0.5, 5), 2), 2);
                    Console.WriteLine("Площадь круга: {0}", square_3);

                }


            }
            // Метод расчета рандомного числа в заданном диапазоне
            double GetRandomNumber(double minimum, double maximum)
            {
                Random random = new Random();
                return random.NextDouble() * (maximum - minimum) + minimum;
            }
            Console.ReadLine();


        }

    }
}


