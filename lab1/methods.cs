using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Methods
    {
        public int sumLastNums(int x) /// 1
        {
            return (x % 10) + (x % 100 / 10);
        }
        public bool isPositive(int x) /// 2
        {
            return x >= 0;
        }
        public bool isUpperCase(char x) /// 3
        {
            return x >= 'A' && x <= 'Z';
        }
        public bool isDivisor(int a, int b) /// 4
        {
            return  (a % b) == 0 || (b % a) == 0;
        }
        public int lastNumSum(int a, int b) /// 5
        {
            return (a % 10) + (b % 10);
        }
        public double safeDiv(int x, int y) /// 6
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
        public String makeDecision(int x, int y) /// 7
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
        public bool sum3(int x, int y, int z) /// 8
        {
            if (x + y == z) 
            {
                return x + y == z;
            }
            else if (x + z == y)
            {
                return x + z == y;
            }
            else if (y + z == x)
            {
                return y + z == x;
            }
            else
            {
                return false;
            }
        }
        public String age(int x) /// 9
        {
            if (x % 10 == 1 && x != 11)
            {
                return "Вам " + x + " год";
            }
            else if ((x % 10 >= 2 && x % 10 <= 4) && ! (x >= 12 && x <= 14))
            {
                return "Вам " + x + " года";
            }
            else
            {
                return "Вам " + x + " лет";
            }
        }
        public void printDays(string x) /// 10
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
        public String reverseListNums(int x) /// 11
        {
            string result = "";

            while (x >= 0)
            {
                result += x + " ";
                x--;
            }

            return result;
        }
        public int pow(int x, int y) /// 12
        {
            int pow = 1;

            for (int i = 0; i < y; i++)
            {
                pow *= x; 
            }

            return pow;
        }
        public bool equalNum(int x) /// 13
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
        public void leftTriangle(int x) /// 14
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
        public void guessGame() /// 15
        {
            Random random = new Random();
            int secretNumber = random.Next(0, 10); // Генерируем число от 0 до 9
            int attempts = 0;
            int userGuess;

            Console.WriteLine("Угадайте число от 0 до 9!");

            do
            {
                Console.Write("Введите число от 0 до 9: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Вы угадали!");
                }
                else
                {
                    Console.WriteLine("Вы не угадали, введите число от 0 до 9:");
                }
            }
            while (userGuess != secretNumber);

            Console.WriteLine($"Вы отгадали число за {attempts} попыт(ки/ок)");
        }
        public int findLast(int[] arr, int x) /// 16
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i + 1;
                }   
            }

            return -1;
        }
        public int[] add(int[] arr, int x, int pos) /// 17
        {
            
            if (pos < 0 || pos > arr.Length)
            {
                Console.WriteLine($"Ошибка: позиция {pos} выходит за границы массива");
                return arr;
            }

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
        public void reverse(int[] arr) /// 18
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
                newArr[i+arr1.Length] = arr2[i];
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
    }
}
