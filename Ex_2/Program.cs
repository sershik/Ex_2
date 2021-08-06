using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Яковлев Сергей
            //Task_1
            static int Min3(int a, int b, int c)
            {
                if (a <= b && a <= c)
                {
                    return a;
                }
                else if (b <= c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }

            //Task_2
            static int SumNum(int a)
            {
                int count = 0;
                while (a != 0)
                {
                    a = a / 10;
                    count++;
                }
                return count;
            }

            //Tusk_3
            static int SumOdd()
            {
                int Sum = 0;
                while (true)
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 0)
                    {
                        break;
                    }
                    else if (a > 0 && a % 2 != 0)
                    {
                        Sum += a;
                    }
                }

                return Sum;
            }

            //Tusk_4

            static bool Log_In()
            {
                int count = 0;
                do
                {
                    Console.Write("Логин: ");
                    string login = Console.ReadLine();
                    Console.Write("Пароль: ");
                    string password = Console.ReadLine();
                    count++;

                    if (verify(login, password))
                    {
                        return true;
                    }
                } while (count < 3);
                return false;
            }

            //Tusk_5

            static void IMT()
            {
                Console.Write("Рост, м: ");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.Write("Вес, кг: ");
                double m = Convert.ToDouble(Console.ReadLine());
                double imt = m / (h * h);
                Console.WriteLine("ИМТ = {0:F2}", imt);

                if (imt < 18.5)
                {
                    Console.WriteLine("Для идеального веса Вам нужно набрать: {0}", (18.5 - imt) * (h * h));
                }
                else if (imt > 24.99)
                {
                    Console.WriteLine("Для идеального веса Вам нужно сбросить: {0}", (imt - 24.99) * (h * h));
                }
                else
                {
                    Console.WriteLine("У вас идеальный вес");
                }
            }

            //Tusk_7
            static void Task_7(int a, int b)
            {
                if (a > b)
                {
                    Console.WriteLine("Ошибка, a > b. Программа завершена.");
                }
                else
                {
                    Console.WriteLine(a);
                    if (b > a)
                    {
                        Task_7(a + 1, b);
                    }
                }
            }
        }
    }
}
