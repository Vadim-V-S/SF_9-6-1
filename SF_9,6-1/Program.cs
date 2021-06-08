using System;

namespace SF_9_6_1
{
    class Program
    {
           static int num;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите целое четное не равное 0 число для возведения в квадрат:\t");
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 != 0) throw new Exception("Нечетное число");
                    if (num == 0)  throw new Exception("0");

                    Pow(num);

                }
                catch (Exception ex) when (ex is FormatException)
                {
                    if (num != 0) { Console.WriteLine($"Ошибка ввода: {ex.Message}"); }
                    else { Console.WriteLine($"Ошибка ввода: Значение не введено"); }
                }

                catch (Exception ex) when (ex.Message == "Нечетное число")
                {
                    Console.WriteLine("Ошибка: Нечетное число");
                }

                catch (Exception ex) when (ex is OverflowException)
                {
                    Console.WriteLine($"Ошибка: Число слишком большое. {ex.Message}");
                }
                catch (Exception ex) when (ex.Message == "0")
                {
                    Console.WriteLine($"Ошибка: Значение равно 0");
                }
            }
        }

        static void Pow(int num) => Console.WriteLine($"Результат: {num *= num}");
    }
}
