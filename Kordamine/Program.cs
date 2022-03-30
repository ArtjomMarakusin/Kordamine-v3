using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 3 Вариант

            bool x = true;
            while (x)
            {
                Console.WriteLine("1 Задание - 1");
                Console.WriteLine("2 Задание - 2");
                Console.WriteLine("3 Задание - 3");
                Console.WriteLine("Выход - 4");
                Console.WriteLine();

                int t = int.Parse(Console.ReadLine());

                switch (t)
                {
                    case 1:
                        MinMax.minmax();
                        break;
                    case 2:
                        Nums.nums();
                        break;
                    case 3:
                        Iosif.iosif();
                        break;
                    case 4:
                        Console.WriteLine("Закройте программу.");
                        x = false;
                        break;
                    default:
                        Console.WriteLine("Введите правильное задание");
                        break;
                }
            }

            Console.ReadLine();

        }
    }
}
