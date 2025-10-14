using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();

            while (true)
            {
                Console.WriteLine("\nМетоды");
                Console.WriteLine("1) Результат сложения двух последних цифр в числе");
                Console.WriteLine("2) Проверка числа на положительность");
                Console.WriteLine("3) Проверка регистра буквы");
                Console.WriteLine("4) Проверка деления любого числа из двух на другое нацело");
                Console.WriteLine("5) Сумма цифр двух чисел из разряда единиц");
                Console.WriteLine("6) Деление чисел");
                Console.WriteLine("7) Сравнение двух чисел");
                Console.WriteLine("8) Тройная сумма");
                Console.WriteLine("9) Ваш возраст");
                Console.WriteLine("10) Вывод дней недели");
                Console.WriteLine("11) Числа наоборот");
                Console.WriteLine("12) Возведение в степень");
                Console.WriteLine("13) Проверка цифр в числе на одинаковость");
                Console.WriteLine("14) Левый треугольник");
                Console.WriteLine("15) Игра 'Угадай число'");
                Console.WriteLine("16) Последнее вхождение числа в массив");
                Console.WriteLine("17) Добавление нового числа в массив");
                Console.WriteLine("18) Вывод массива задом-наперед");
                Console.WriteLine("19) Объединение двух массивов");
                Console.WriteLine("20) Удаление отрицательных чисел из массива");
                Console.Write("Выберите номер метода или введите число 21 для выхода из программы: ");
                int x = methods.ReadIntInRange(1, 21, "Выберите номер метода или введите число 21 для выхода из программы: ");

                if (x == 21)
                {
                    break;
                }

                switch (x)
                {
                    case 1:
                        x = methods.ReadInt("Введите число: ");
                        int num = methods.sumLastNums(x);
                        Console.WriteLine("Сумма чисел равна: " + num);
                        break;
                    case 2:
                        x = methods.ReadInt("Введите число: ");
                        Console.WriteLine(methods.isPositive(x));
                        break;
                    case 3:
                        Console.Write("Введите символ: ");
                        string str = Console.ReadLine();
                        char letter = str[0];
                        Console.WriteLine(methods.isUpperCase(letter));
                        break;
                    case 4:
                        int a = methods.ReadInt("Введите первое число: ");
                        int b = methods.ReadInt("Введите второе число: ");
                        Console.WriteLine(methods.isDivisor(a, b));
                        break;
                    case 5:
                        a = methods.ReadInt("Введите первое число: ");
                        b = methods.ReadInt("Введите второе число: ");
                        Console.WriteLine(methods.lastNumSum(a, b));
                        break;
                    case 6:
                        a = methods.ReadInt("Введите число X: ");
                        b = methods.ReadInt("Введите число Y: ");
                        Console.WriteLine(methods.safeDiv(a, b));
                        break;
                    case 7:
                        a = methods.ReadInt("Введите первое число: ");
                        b = methods.ReadInt("Введите второе число: ");
                        Console.WriteLine(methods.makeDecision(a, b));
                        break;
                    case 8:
                        a = methods.ReadInt("Введите первое число: ");
                        b = methods.ReadInt("Введите второе число: ");
                        int c = methods.ReadInt("Введите третье число: ");
                        Console.WriteLine(methods.sum3(a, b, c));
                        break;
                    case 9:
                        x = methods.ReadNonNegativeInt("Введите ваш возраст: ");
                        Console.WriteLine(methods.age(x));
                        break;
                    case 10:
                        Console.Write("Введите день недели: ");
                        str = Console.ReadLine();
                        methods.printDays(str);
                        break;
                    case 11:
                        x = methods.ReadNonNegativeInt("Введите число: ");
                        Console.WriteLine(methods.reverseListNums(x));
                        break;
                    case 12:
                        a = methods.ReadInt("Введите число: ");
                        b = methods.ReadNonNegativeInt("Введите степень числа: ");
                        Console.WriteLine(methods.pow(a, b));
                        break;
                    case 13:
                        x = methods.ReadInt("Введите число: ");
                        Console.WriteLine(methods.equalNum(x));
                        break;
                    case 14:
                        x = methods.ReadNonNegativeInt("Введите число: ");
                        methods.leftTriangle(x);
                        break;
                    case 15:
                        methods.guessGame();
                        break;
                    case 16:
                        int size = methods.ReadArraySize("Введите размер массива: ");
                        int[] arr = methods.ReadIntArray(size, "массива");
                        x = methods.ReadInt("Введите число для поиска: ");
                        int position = methods.findLast(arr, x);
                        Console.WriteLine(position == -1 ? "Элемент не найден" : $"Элемент найден на позиции: {position}");
                        break;
                    case 17:
                        size = methods.ReadArraySize("Введите размер массива: ");
                        arr = methods.ReadIntArray(size, "массива");
                        x = methods.ReadInt("Введите новый элемент для добавления в массив: ");
                        int pos = methods.ReadIntInRange(0, size, "Введите номер позиции в которую будет добавлен новый элемент: ");
                        int[] resultArr = methods.add(arr, x, pos);
                        Console.WriteLine("Новый массив: [" + string.Join(", ", resultArr) + "]");
                        break;
                    case 18:
                        size = methods.ReadArraySize("Введите размер массива: ");
                        arr = methods.ReadIntArray(size, "массива");
                        methods.reverse(arr);
                        Console.WriteLine("Новый массив: [" + string.Join(", ", arr) + "]");
                        break;
                    case 19:
                        int size1 = methods.ReadArraySize("Введите размер массива 1: ");
                        int[] arr1 = methods.ReadIntArray(size1, "первого массива");
                        int size2 = methods.ReadArraySize("Введите размер массива 2: ");
                        int[] arr2 = methods.ReadIntArray(size2, "второго массива");
                        resultArr = methods.concat(arr1, arr2);
                        Console.WriteLine("Объединенный массив: " + string.Join(", ", resultArr));
                        break;
                    case 20:
                        size = methods.ReadArraySize("Введите размер массива: ");
                        arr = methods.ReadIntArray(size, "массива");
                        resultArr = methods.deleteNegative(arr);
                        Console.WriteLine("Массив без отрицательных значений: " + string.Join(", ", resultArr));
                        break;
                    default:
                        Console.WriteLine("Метод с таким номером не существует");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
