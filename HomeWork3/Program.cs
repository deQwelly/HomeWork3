using System;

namespace hw3
{
    internal class Program
    {
        enum Months
        {
            January = 31,
            February = 59,
            March = 90,
            April = 120,
            May = 151,
            June = 181,
            July = 212,
            August = 243,
            September = 273,
            October = 304,
            November = 334,
            December = 365
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1: Написать программу, которая читает с экрана число от 1 до 365 (номер дня\r\n" +
                "в году), переводит этот число в месяц и день месяца. (високосный год не учитывать).\nУпражнение 4.2: Добавить к " +
                "задаче из предыдущего упражнения проверку числа введенного\r\nпользователем. Если число меньше 1 или больше 365, " +
                "программа должна вырабатывать\r\nисключение, и выдавать на экран сообщение.\nДомашнее задание 4.1: Изменить программу" +
                " из упражнений 4.1 и 4.2 так, чтобы она\r\nучитывала год (високосный или нет). Год вводится с экрана. (Год високосный," +
                " если он\r\nделится на четыре без остатка, но если он делится на 100 без остатка, это не високосный\r\nгод. Однако, если" +
                " он делится без остатка на 400, это високосный год.)");
            Console.Write("\nВведите номер года: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                if (year > 0)
                {
                    byte leap = 0;
                    if (((year % 4 == 0) & (year % 100 != 0)) | (year % 400 == 0))
                    {
                        Console.Write("Вы выбрали високосный год\n" +
                            "Введите порядковый номер дня в этом году (от 1 до 366): ");
                        leap++;
                    }
                    else
                    {
                        Console.Write("Вы выбрали не високосный год\n" +
                            "Введите порядковый номер дня в этом году (от 1 до 365): ");
                    }
                    if (int.TryParse(Console.ReadLine(), out int day))
                    {
                        if ((day >= 1) & (day <= 31))
                        {
                            Console.WriteLine($"Январь {day}");
                        }
                        else if ((day >= 32) & (day <= (59 + leap)))
                        {
                            Console.WriteLine($"Февраль {day - 31}");
                        }
                        else if ((day >= (60 + leap)) & (day <= (90 + leap)))
                        {
                            Console.WriteLine($"Март {day - (59 + leap)}");
                        }
                        else if ((day >= (91 + leap)) & (day <= (120 + leap)))
                        {
                            Console.WriteLine($"Апрель {day - (90 + leap)}");
                        }
                        else if ((day >= (121 + leap)) & (day <= (151 + leap)))
                        {
                            Console.WriteLine($"Май {day - (120 + leap)}");
                        }
                        else if ((day >= (152 + leap)) & (day <= (181 + leap)))
                        {
                            Console.WriteLine($"Июнь {day - (151 + leap)}");
                        }
                        else if ((day >= (182 + leap)) & (day <= (212 + leap)))
                        {
                            Console.WriteLine($"Июль {day - (181 + leap)}");
                        }
                        else if ((day >= (213 + leap)) & (day <= (243 + leap)))
                        {
                            Console.WriteLine($"Август {day - (212 + leap)}");
                        }
                        else if ((day >= (244 + leap)) & (day <= (273 + leap)))
                        {
                            Console.WriteLine($"Сентябрь {day - (243 + leap)}");
                        }
                        else if ((day >= (274 + leap)) & (day <= (304 + leap)))
                        {
                            Console.WriteLine($"Октябрь {day - (273 + leap)}");
                        }
                        else if ((day >= (305 + leap)) & (day <= (334 + leap)))
                        {
                            Console.WriteLine($"Ноябрь {day - (304 + leap)}");
                        }
                        else if ((day >= (335 + leap)) & (day <= (365 + leap)))
                        {
                            Console.WriteLine($"Декабрь {day - (334 + leap)}");
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели значение, не входящее в указанный диапазон");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели недопустимые символы, дробное значение или не ввели ничего вовсе");
                    }
                }
                else
                {
                    Console.WriteLine("Указанный год не может быть меньше или равен нулю");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели недопустимые символы, дробное значение или не ввели ничего вовсе");
            }
            Console.ReadKey();
        }
    }
}
