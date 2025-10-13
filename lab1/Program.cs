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
            while (true)
            {
                Console.Write("Выберите номер метода или введите число 21 для выхода из программы: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 21)
                {
                    break;
                }
                Methods methods = new Methods();
                switch (x)
                {
                    case 1: 
                        Console.Write("Введите число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        int num = methods.sumLastNums(x);
                        Console.WriteLine("Сумма чисел равна: " + num); break;
                    case 2: 
                        Console.Write("Введите число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(methods.isPositive(x)); break;
                    case 3:
                        Console.Write("Введите символ: ");
                        string str = Console.ReadLine();
                        char letter = str[0];
                        Console.WriteLine(methods.isUpperCase(letter));
                        break;
                    case 4:                  
                        Console.Write("Введите первое число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        int a = x;
                        Console.Write("Введите второе число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        int b = x;
                        Console.WriteLine(methods.isDivisor(a,b));
                        break;
                    case 5:
                        Console.Write("Введите первое число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        a = x;
                        Console.Write("Введите второе число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        b = x;
                        Console.WriteLine(methods.lastNumSum(a, b));
                        break;
                    case 6:
                        Console.Write("Введите число X: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        a = x;
                        Console.Write("Введите число Y: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        b = x;
                        Console.WriteLine(methods.safeDiv(a, b));
                        break;
                    case 7:
                        Console.Write("Введите первое число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        a = x;
                        Console.Write("Введите второе число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        b = x;
                        Console.WriteLine(methods.makeDecision(a, b));
                        break;
                    case 8:
                        Console.Write("Введите первое число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        a = x;
                        Console.Write("Введите второе число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        b = x;                
                        Console.Write("Введите третье число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        int c = x;
                        Console.WriteLine(methods.sum3(a, b, c));
                        break;
                    case 9:
                        Console.Write("Введите ваш возраст: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(methods.age(x));
                        break;
                    case 10:
                        Console.Write("Введите день недели: ");
                        str = Console.ReadLine();
                        methods.printDays(str);
                        break;
                    case 11:
                        Console.Write("Введите число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(methods.reverseListNums(x));
                        break;
                    case 12:
                        Console.Write("Введите число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        a = x;
                        Console.Write("Введите степень числа: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        b = x;
                        Console.WriteLine(methods.pow(a, b));
                        break;
                    case 13:
                        Console.Write("Введите число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(methods.equalNum(x));
                        break;
                    case 14:
                        Console.Write("Введите число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        methods.leftTriangle(x);
                        break;
                    case 15:
                        methods.guessGame();
                        break;
                    case 16:
                        Console.Write("Введите размер массива: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[x];
                        Console.WriteLine($"Введите {x} чисел:");

                        for (int i = 0; i < x; i++)
                        {
                            Console.Write($"Элемент {i + 1}: ");
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Write("Введите число для поиска: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(methods.findLast(arr, x));
                        break;
                    case 17:
                        Console.Write("Введите размер массива: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        arr = new int[x];
                        Console.WriteLine($"Введите {x} чисел:");

                        for (int i = 0; i < x; i++)
                        {
                            Console.Write($"Элемент {i + 1}: ");
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Write("Введите новый элемент для добавления в массив: ");
                        x = Convert.ToInt32(Console.ReadLine());                     
                        Console.Write("Введите номер позиции в которую будет добавлен новый элемент: ");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        int[] resultArr = methods.add(arr, x, pos);
                        Console.WriteLine("Новый массив: [" + string.Join(", ", resultArr) + "]");
                        break;
                    case 18:
                        Console.Write("Введите размер массива: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        arr = new int[x];
                        Console.WriteLine($"Введите {x} чисел:");

                        for (int i = 0; i < x; i++)
                        {
                            Console.Write($"Элемент {i + 1}: ");
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        methods.reverse(arr);
                        Console.WriteLine("Новый массив: [" + string.Join(", ", arr) + "]");
                        break;
                    case 19:
                        Console.Write("Введите размер массива 1: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        int[] arr1 = new int[x];
                        Console.WriteLine($"Введите {x} чисел для первого массива:");

                        for (int i = 0; i < x; i++)
                        {
                            Console.Write($"Элемент {i + 1}: ");
                            arr1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Введите размер массива 2: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        int[] arr2 = new int[x];
                        Console.WriteLine($"Введите {x} чисел для второго массива:");

                        for (int i = 0; i < x; i++)
                        {
                            Console.Write($"Элемент {i + 1}: ");
                            arr2[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        resultArr = methods.concat(arr1, arr2);
                        Console.WriteLine("Объединенный массив: " + string.Join(", ", resultArr));
                        break;
                    case 20:
                        Console.Write("Введите размер массива: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        arr = new int[x];
                        Console.WriteLine($"Введите {x} чисел:");

                        for (int i = 0; i < x; i++)
                        {
                            Console.Write($"Элемент {i + 1}: ");
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        resultArr = methods.deleteNegative(arr);
                        Console.WriteLine("Массив без отрицательных значений: " + string.Join(", ", resultArr));
                        break;
                }
            }

        }
    }
}