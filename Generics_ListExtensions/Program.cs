using System;
using System.Collections.Generic;

namespace Generics_ListExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3 };
            Console.WriteLine("Исходный список чисел: " + string.Join(", ", numbers));
            numbers.Swap(0, 2);
            Console.WriteLine("После Swap(0, 2): " + string.Join(", ", numbers));

            List<string> emptyList = new List<string>();
            List<string> filledList = new List<string> { "a" };

            Console.WriteLine($"emptyList.IsEmpty(): {emptyList.IsEmpty()}");
            Console.WriteLine($"filledList.IsEmpty(): {filledList.IsEmpty()}");

            Console.WriteLine();
            Console.WriteLine("=== Интерактивный режим работы с расширениями списка ===");

            while (true)
            {
                try
                {
                    Console.Write("Введите элементы через пробел для создания списка (или 'stop' для выхода): ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input) || input.Trim().ToLower() == "stop")
                    {
                        break;
                    }

                    List<string> userList = new List<string>(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                    Console.WriteLine($"Проверка IsEmpty(): {userList.IsEmpty()}");

                    if (userList.Count >= 2)
                    {
                        Console.Write("Введите первый индекс для Swap (от 0 до " + (userList.Count - 1) + "): ");
                        int i = int.Parse(Console.ReadLine());

                        Console.Write("Введите второй индекс для Swap (от 0 до " + (userList.Count - 1) + "): ");
                        int j = int.Parse(Console.ReadLine());

                        userList.Swap(i, j);
                        Console.WriteLine("Список после Swap: " + string.Join(", ", userList));
                    }
                    else
                    {
                        Console.WriteLine("В списке меньше двух элементов, операция Swap пропущена.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено некорректное число.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: указанный индекс выходит за пределы списка.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}