using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRanges
/**
 C#: 
Программа получает на входе 5 integer чисел первые - четыре это начало 
и конец двух диапазонов чисел (включительно). Надо проверить, если пятое 
число входит в оба диапазона или нет - выдача результата true или false
Считаем что вводимые диапазоны пересекаются.
Пример ввода:
10
20
17
45
11
Вывод: true

Пример ввода:
-67
89
34
37
33
Вывод: false
 */
{
    internal class NumberInRanges
    {
        static void Main(string[] args)
        {
            Console.Write("Введите нижнюю границу первого диапазона: ");
            int lowBoundOfRangeOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите верхнюю границу первого диапазона: ");
            var boundOfRangeOne = int.Parse(Console.ReadLine());
            Console.Write($"Введите число для проверки принадлежности введенному диапазону [{lowBoundOfRangeOne}..{boundOfRangeOne}]: ");
            Int32 numberToCheck = int.Parse(Console.ReadLine());
            Console.WriteLine($"введенное число {numberToCheck} принадлежит диапазону [{lowBoundOfRangeOne}..{boundOfRangeOne}]: " +
                              $"{numberToCheck >= lowBoundOfRangeOne && numberToCheck <= boundOfRangeOne}");
        }
    }
}
