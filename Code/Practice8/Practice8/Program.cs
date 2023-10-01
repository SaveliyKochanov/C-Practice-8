using System;

namespace Practice8
{
    class ClassPractice
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Здравствуйте, данная программа поможет вам вычислить значение y в системе уравнений, в зависимости от значений, введённых вами в переменные k и x");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" *Если введенное значение k = 3, 6 или же 11, то y = (2 * x) + 5");
            Console.WriteLine(" *Если введенное значение k = 9 или 10, то y = (10 - x)");
            Console.WriteLine(" *Если введенное значение k = 13, то y = (x ^ 3)");
            Console.WriteLine(" *Если введенное значение k не подходит не под одно из вышеперечисленных условий, но оно находится в промежутке от 3 до 15, то y = (12 * x)");
            double y = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("- Введите значение переменной k: ");
            int k = int.Parse(Console.ReadLine());

            if (3 <= k && k <= 15)
            {
                Console.Write("- Введите значение переменной x: ");
                double x = Double.Parse(Console.ReadLine());
                switch (k)
                {
                    case 3:
                    case 6:
                    case 11:
                        y = (2 * x) + 5;
                        Console.WriteLine($"Так как введенное число {k} подходит под условие:\n Если значение k = 3, 6 или же 11, то y = (2 * x) + 5, значит y = (2 * {x} + 5) ");
                        break;
                    case 9:
                    case 10:
                        y = 10 - x;
                        Console.WriteLine($"Так как введенное число {k} подходит под условие:\n Если значение k = 9 или 10, то y = (10 - x), значит y = (10 - {x})");
                        break;
                    case 13:
                        y = Math.Pow(x, 3);     
                        Console.WriteLine($"Так как введенное число {k} подходит под условие:\n Если значение k = 13, то y = (x ^ 3), значит y = ( {x} ^ 3)");
                        break;
                    default:
                        y = 12 * x;
                        Console.WriteLine($"Так как введенное число {k} не подходит не под одно из вышеперечисленных условий,\n то y = (12 * x), значит y = ( 12 * {x})");
                        break;
                }
                Console.WriteLine($"- Значение y = {y}. Благодарю за использование моей программы, всего доброго!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("____________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                if (3 > k && k > 15)
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("- Введенное вами значение y не находится в промежутке от 5 до 15, попробуйте снова.");
                Console.WriteLine("________________________________________________________________________________");
            }

        }

    }
}
