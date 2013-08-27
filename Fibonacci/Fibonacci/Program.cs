using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class Fib
    {
        static int CreateNumbersAtIndex(int index)
        {
            if (index < 2) return 1;

            return CreateNumbersAtIndex(index - 1) + CreateNumbersAtIndex(index - 2);
        }


        public static IEnumerable<int> CreateNumbers()
        {
            int index = 0;
            while (true)
            {
                yield return CreateNumbersAtIndex(index);

                index++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
