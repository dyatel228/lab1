using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Methods
    {
        public int sumLastNums(int x) // 1
        {
            return (x % 10) + (x % 100 / 10);
        }

        public bool isPositive(int x) // 2
        {
            return x >= 0;
        }

        public bool isUpperCase(char x) // 3
        {
            return x >= 'A' && x <= 'Z';
        }

        public bool isDivisor(int a, int b) // 4
        {
            return (a % b) == 0 || (b % a) == 0;
        }

        public int lastNumSum(int a, int b) // 5
        {
            int c = (a % 10) + (b % 10);
            Console.WriteLine($"{a} + {b} это {c}");
            Console.Write("Введите новое число для сложения с предыдущим: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = (c % 10) + (a % 10);
            Console.WriteLine($"{c} + {a} это {b}");
            Console.Write("Введите новое число для сложения с предыдущим: ");
            a = Convert.ToInt32(Console.ReadLine());
            c = (b % 10) + (a % 10);
            Console.WriteLine($"{b} + {a} это {c}");
            Console.Write("Введите новое число для сложения с предыдущим: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = (c % 10) + (a % 10);
            Console.WriteLine($"{c} + {a} это {b}");
            return b;
        }

        public double safeDiv(int x, int y) // 6
        {
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return x / y;
            }
        }

        public String makeDecision(int x, int y) // 7
        {
            if (x > y)
            {
                return x + " > " + y;
            }
            else if (x < y)
            {
                return x + " < " + y;
            }
            else
            {
                return x + " == " + y;
            }
        }

        public bool sum3(int x, int y, int z) // 8
        {
            return x + y == z || x + z == y || y + z == x;
        }

        public String age(int x) // 9
        {
            if (x % 10 == 1 && x != 11)
            {
                return "Вам " + x + " год";
            }
            else if ((x % 10 >= 2 && x % 10 <= 4) && !(x >= 12 && x <= 14))
            {
                return "Вам " + x + " года";
            }
            else
            {
                return "Вам " + x + " лет";
            }
        }

        public void printDays(string x) // 10
        {
            switch (x.ToLower())
            {
                case "понедельник":
                    Console.WriteLine("понедельник");
                    goto case "вторник";
                case "вторник":
                    Console.WriteLine("вторник");
                    goto case "среда";
                case "среда":
                    Console.WriteLine("среда");
                    goto case "четверг";
                case "четверг":
                    Console.WriteLine("четверг");
                    goto case "пятница";
                case "пятница":
                    Console.WriteLine("пятница");
                    goto case "суббота";
                case "суббота":
                    Console.WriteLine("суббота");
                    goto case "воскресенье";
                case "воскресенье":
                    Console.WriteLine("воскресенье");
                    break;
                default:
                    Console.WriteLine("это не день недели");
                    break;
            }
        }

        public String reverseListNums(int x) // 11
        {
            string result = "";

            while (x >= 0)
            {
                result += x + " ";
                x--;
            }

            return result;
        }

        public int pow(int x, int y) // 12
        {
            int pow = 1;

            for (int i = 0; i < y; i++)
            {
                pow *= x;
            }

            return pow;
        }

        public bool equalNum(int x) // 13
        {
            if (x == 0)
            {
                return true;
            }

            if (x < 0)
            {
                x = -x;
            }

            int lastDigit = x % 10;

            while (x > 0)
            {
                if (x % 10 != lastDigit)
                {
                    return false;
                }

                x /= 10;
            }

            return true;
        }

        public void leftTriangle(int x) // 14
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public void guessGame() // 15
        {
            Random random = new Random();
            int secretNumber = random.Next(0, 10);
            int attempts = 0;
            int userGuess;

            Console.WriteLine("Угадайте число от 0 до 9!");

            do
            {
                userGuess = ReadIntInRange(0, 9, "Введите число от 0 до 9: ");
                attempts++;

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Вы угадали!");
                }
                else
                {
                    Console.WriteLine("Вы не угадали, попробуйте снова.");
                }
            }
            while (userGuess != secretNumber);

            Console.WriteLine($"Вы отгадали число за {attempts} попыт(ки/ок)");
        }

        public int findLast(int[] arr, int x) // 16
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        public int[] add(int[] arr, int x, int pos) // 17
        {

            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < pos; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[pos] = x;

            for (int i = pos; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }
            return newArr;
        }

        public void reverse(int[] arr) // 18
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        public int[] concat(int[] arr1, int[] arr2) // 19
        {
            int[] newArr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[i + arr1.Length] = arr2[i];
            }
            return newArr;
        }

        public int[] deleteNegative(int[] arr) // 20
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                    count++;
            }

            int[] result = new int[count];

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }

            return result;
        }

        public int ReadInt(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введено не число. Попробуйте снова.");
                }
            }
        }
        public int ReadIntInRange(int min, int max, string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number >= min && number <= max)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка: Число должно быть в диапазоне от {min} до {max}. Попробуйте снова.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введено не число. Попробуйте снова.");
                }
            }
        }

        public int ReadNonNegativeInt(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number >= 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Число не может быть отрицательным. Попробуйте снова.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введено не число. Попробуйте снова.");
                }
            }
        }
        public int[] ReadIntArray(int size, string arrayName)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = ReadInt($"Введите элемент {i + 1} для {arrayName}: ");
            }

            return array;
        }


        public int ReadArraySize(string prompt)
        {
            return ReadIntInRange(1, 25, prompt);
        }
    }
}
