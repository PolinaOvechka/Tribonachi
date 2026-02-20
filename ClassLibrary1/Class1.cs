using System;
using System.Collections.Generic;

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
                if (i == 0)
                    trib.Add(0);
                else if (i == 1)
                    trib.Add(1);
                else if (i == 2)
                    trib.Add(1);
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
            result.Add("Член: Значение (Отношение)");
            result.Add("----------------------------");

            // Строки с данными (индексация с 0, как в математике)
            for (int i = 0; i < trib.Count; i++)
            {
                // Отношение не определено для:
                // - первого элемента (нет предыдущего)
                // - если предыдущий элемент = 0 (деление на ноль)
                if (i == 0 || trib[i - 1] == 0)
                    result.Add(i + ": " + trib[i] + " (---)");
                else
                {
                    double ratio = (double)trib[i] / trib[i - 1];
                    result.Add(i + ": " + trib[i] + " (" + ratio.ToString("F4") + ")");
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
                if (i == 0)
                    fib.Add(0);  // F₀ = 0 ← ДОБАВЛЕНО!
                else if (i == 1)
                    fib.Add(1);  // F₁ = 1
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
            result.Add("Член: Значение (Отношение)");
            result.Add("----------------------------");

            // Строки с данными (с проверкой деления на ноль)
            for (int i = 0; i < fib.Count; i++)
            {
                // Отношение не определено для первого элемента или при делении на 0
                if (i == 0 || fib[i - 1] == 0)
                    result.Add(i + ": " + fib[i] + " (---)");
                else
                {
                    double ratio = (double)fib[i] / fib[i - 1];
                    result.Add(i + ": " + fib[i] + " (" + ratio.ToString("F4") + ")");
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
                if (i == 0)
                    result.Add(0); 
                else if (i == 1)
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
                if (i == 0)
                    result.Add(0);
                else if (i == 1)
                    result.Add(1);
                else if (i == 2)
                    result.Add(1);
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