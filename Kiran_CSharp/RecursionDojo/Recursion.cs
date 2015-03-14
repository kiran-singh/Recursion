using System.Collections.Generic;
using System.Linq;

namespace RecursionDojo
{
    public class Recursion
    {
        public int Factorial(int input)
        {
            return input == 0 ? 1 : input*Factorial(input - 1);
        }

        public int Fibonacci(int input)
        {
            return input == 1 || input == 2 ? 1 : Fibonacci(input - 1) + Fibonacci(input - 2);
        }

        public int SumOfList(List<int> items)
        {
            return items.Count == 0 ? 0 : items.Pop() + SumOfList(items);
        }

        public int ItemsInList(List<int> items)
        {
            if (items.Count == 0)
            {
                return 0;
            }

            items.Remove(items[0]);

            return 1 + ItemsInList(items);
        }

        public bool IsEven(int number)
        {
            return number == 0 || IsOdd(number - 1);
        }

        public bool IsOdd(int number)
        {
            return number != 0 && IsEven(number - 1);
        }

        public int Ackermann(int m, int n)
        {
            return m == 0 ? n + 1 : (n == 0 ? Ackermann(m - 1, 1) : 0);
        }
    }
}