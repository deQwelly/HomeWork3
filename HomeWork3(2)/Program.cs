using System;

namespace hw3_2_
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {
            // Упражнение 1
            Console.WriteLine("Упражнение 1: Дана последовательность из 10 чисел. Определить, является" +
                " ли эта последовательность\r\nупорядоченной по возрастанию. В случае отрицательного ответа" +
                " определить\r\nпорядковый номер первого числа, которое нарушает данную последовательность.\r\nИспользовать break.");
            int[] sequence = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Введите {i + 1}-ое число последовательности: ");
                    sequence[i] = Convert.ToInt32(Console.ReadLine());
                }
                /// for (int i = 0; i < sequence.Length; i ++) { Console.WriteLine(sequence[i]); }
                bool flag = true;
                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] >= sequence[i + 1])
                    {
                        Console.WriteLine($"Возрастающая последовательность прерывается после {i + 1}-го элемента");
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Последовательность является возрастающей");
                }
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Вы ввели слишком большое или, наоборот, маленькое число");
            }
            catch
            {
                Console.WriteLine("Недопустимый формат ввода данных. Возможно, вы ввели дробное число, нечисловые символы или не ввели ничего вовсе");
            }

            // Упражнение 2
            Console.WriteLine("\nУпражнение 2: Игральным картам условно присвоены следующие порядковые номера в зависимости от\r\n" +
                "их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.\r\nПорядковые номера остальных" +
                " карт соответствуют их названиям («шестерка»,\r\n«девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14)" +
                " определить достоинство\r\nсоответствующей карты.");
            Console.Write("Введите число от 6 до 14: ");
            try
            {
                switch (Convert.ToByte(Console.ReadLine()))
                {
                    case 6: Console.WriteLine("Шесть"); break;
                    case 7: Console.WriteLine("Семь"); break;
                    case 8: Console.WriteLine("Восемь"); break;
                    case 9: Console.WriteLine("Девять"); break;
                    case 10: Console.WriteLine("Десять"); break;
                    case 11: Console.WriteLine("Валет"); break;
                    case 12: Console.WriteLine("Дама"); break;
                    case 13: Console.WriteLine("Король"); break;
                    case 14: Console.WriteLine("Туз"); break;
                    default: Console.WriteLine("Вы ввели символы, не входящие в диапазон от 6 до 14"); break;
                }
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Вы ввели слишком большое или, наоборот, маленькое число");
            }
            catch
            {
                Console.WriteLine("Недопустимый формат ввода данных. Возможно, вы ввели дробное число, нечисловые символы или не ввели ничего вовсе");
            }

            // Упражнение 3
            Console.WriteLine("\nУпражнение 3: Напишите программу, которая принимает на входе строку и производит выходные\r\nданные в соответствии со указанной таблицей");
            Console.Write("Введите данные: ");
            switch (Console.ReadLine().ToLower())
            {
                case "jabroni": Console.WriteLine("Patron Tequila"); break;
                case "school counselor": Console.WriteLine("Anything whith Alcohol"); break;
                case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                case "bike gang member": Console.WriteLine("Moonshine"); break;
                case "politician": Console.WriteLine("Your tax dollars"); break;
                case "rapper": Console.WriteLine("Chistal"); break;
                default: Console.WriteLine("Beer"); break;
            }

            // Упражнение 4
            Console.WriteLine("\nУпражнение 4: Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,\r\n...,7)" +
                " выводит на экран его название (понедельник, вторник, ..., воскресенье).");
            Console.Write("Введите номер дня недели: ");
            try
            {
                if (byte.TryParse(Console.ReadLine(), out byte day))
                {
                    Console.WriteLine(Enum.GetName(typeof(DayOfWeek), day - 1));
                }
                else
                {
                    Console.WriteLine("Указанное число может не соответствовать диапазону. Так же, возможно, вы ввели дробное число, нечисловые символы или не ввели ничего вовсе");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }

            // Упражнение 5
            Console.WriteLine("\nУпражнение 5: Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента" +
                "\r\n\"Hello Kitty\" или \"Barbie doll\" необходимо положить их в “сумку”, т.е. прибавить к\r\nрезультату. Вывести на экран сколько кукол в “сумке”.");
            byte count = 0;
            string[] market = new string[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Введите {i + 1}-ый элемент: ");
                    market[i] = Console.ReadLine();
                }
                foreach (string i in market)
                {
                    if ((i.ToLower().Equals("hello kitty")) | (i.ToLower().Equals("barbie doll")))
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Кукол в сумке - {count}");
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
    }
}
