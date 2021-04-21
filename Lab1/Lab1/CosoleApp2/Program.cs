using System;
namespace calc
{
    class calc
    {
        static void Main()
        {
            // ввод чисел
            Console.WriteLine("Введите первое число");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите действие");
            char sign = Convert.ToChar(Console.ReadLine());
            int num = 0;

            // вычисление
            switch (sign)
            {
                case '+':
                    num = num1 + num2; break;
                case '-':
                    num = num1 - num2; break;
                case '*':
                    num = num1 * num2; break;
                case '/':
                    num = num1 / num2; break;
            }

            // вывод
            Console.WriteLine($"{num1} {sign} {num2} = {num}");
        }
    }
}