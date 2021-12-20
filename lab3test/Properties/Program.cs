using System;

namespace lab3stp
{
    class Program
    {
        public static int MaxOfThree(int a, int b, int c)
        {
            int max;
            if (a > b)
                max = a;
            else 
                max = b;
            if (max > c)
                return max;
            else
                return c;
        }

        public static int SummEvenDigit(int a)
        {
            int digitSum = 0;
            string digit;
            if (a.ToString().Length == 1)
                return -1;
            var digits = new int[a.ToString().Length / 2];
            digit = a.ToString();
            for (int i = 1, j = 0; i < a.ToString().Length; i+=2, j++)
            {                           
                switch (digit[i])
                {
                    case '0': 
                        { digits[j] = 0; break; }
                    case '1': 
                        { digits[j] = 1; break; }
                    case '2':
                        { digits[j] = 2; break; }
                    case '3':
                        { digits[j] = 3; break; }
                    case '4':
                        { digits[j] = 4; break; }
                    case '5':
                        { digits[j] = 5; break; }
                    case '6':
                        { digits[j] = 6; break; }
                    case '7':
                        { digits[j] = 7; break; }
                    case '8':
                        { digits[j] = 8; break; }
                    case '9':
                        { digits[j] = 9; break; }
                }                              
            }
            for(int i = 0; i < a.ToString().Length/2; i++)
            {
                digitSum += digits[i];
            }
            return digitSum;
        }

        public static int SearchMinDigit(int a)
        {
            int min = int.MaxValue;
            int number = a;
            for(int i = 0; i < a.ToString().Length; i++)
            {
                if (number % 10 <= min)
                {
                    min = number % 10;
                    number /= 10;
                }
                else
                {
                    number /= 10;
                }
            }
            return min;
        }

        public static int GetSumOddElements(int[][] Array)
        {
            int sum = 0;
            for(int i = 0; i < Array.Length; i++)
            {
                for(int j = i; j < Array[i].Length; j++)
                {
                    if(Array[i][j] % 2 == 1)
                    {
                        sum += Array[i][j];
                    }
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
        }
    }
}
