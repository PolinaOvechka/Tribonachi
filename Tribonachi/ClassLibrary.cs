using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Sequences
    {

        // Метод для Трибоначчи
        public static List<string> GenerateTribonacciStrings(int n)
        {
            List<string> result = new List<string>();

            if (n < 1)
            {
                result.Add("Ошибка: N должно быть >= 1");
                return result;
            }

            List<long> trib = new List<long>();
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                    trib.Add(1);
                else if (i == 2)
                    trib.Add(2);
                else
                {
                    long next = trib[i - 1] + trib[i - 2] + trib[i - 3];
                    if (next < 0)
                    {
                        result.Add("Ошибка: переполнение");
                        return result;
                    }
                    trib.Add(next);
                }
            }

            // ЗАГОЛОВОК
            result.Add("№: Значение (Отношение)");
            result.Add("------------------------");

            // Строки с данными
            for (int i = 0; i < trib.Count; i++)
            {
                if (i == 0)
                    result.Add((i + 1) + ": " + trib[i] + " (---)");
                else
                {
                    double ratio = (double)trib[i] / trib[i - 1];
                    result.Add((i + 1) + ": " + trib[i] + " (" + ratio.ToString("F4") + ")");
                }
            }

            return result;
        }

        // Метод для Фибоначчи
        public static List<string> GenerateFibonacciStrings(int n)
        {
            List<string> result = new List<string>();

            if (n < 1)
            {
                result.Add("Ошибка: N должно быть >= 1");
                return result;
            }

            List<long> fib = new List<long>();
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                    fib.Add(1);
                else
                {
                    long next = fib[i - 1] + fib[i - 2];
                    if (next < 0)
                    {
                        result.Add("Ошибка: переполнение");
                        return result;
                    }
                    fib.Add(next);
                }
            }

            // ЗАГОЛОВОК
            result.Add("№: Значение (Отношение)");
            result.Add("------------------------");

            // Строки с данными
            for (int i = 0; i < fib.Count; i++)
            {
                if (i == 0)
                    result.Add((i + 1) + ": " + fib[i] + " (---)");
                else
                {
                    double ratio = (double)fib[i] / fib[i - 1];
                    result.Add((i + 1) + ": " + fib[i] + " (" + ratio.ToString("F4") + ")");
                }
            }

            return result;
        }

        // === ЗАДАНИЕ 3 ===
        // Генерация Фибоначчи ЧИСЛА (для графика)
        public static List<long> GenerateFibonacciNumbers(int n)
        {
            List<long> result = new List<long>();

            if (n < 1)
                return null;

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                    result.Add(1);
                else
                {
                    long next = result[i - 1] + result[i - 2];
                    if (next < 0)
                        return null;
                    result.Add(next);
                }
            }

            return result;
        }

        // Генерация Трибоначчи ЧИСЛА (для графика)
        public static List<long> GenerateTribonacciNumbers(int n)
        {
            List<long> result = new List<long>();

            if (n < 1)
                return null;

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                    result.Add(1);
                else if (i == 2)
                    result.Add(2);
                else
                {
                    long next = result[i - 1] + result[i - 2] + result[i - 3];
                    if (next < 0)
                        return null;
                    result.Add(next);
                }
            }

            return result;
        }
    }
}
