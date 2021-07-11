using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static int TrailingZeros(int n)
        {
            int result = 0;
            var factorial = new BigInteger(1);
            int j = 1;
            while (j <= n)
            {
                factorial *= j;
                ++j;
            }
            Console.WriteLine(factorial);
            string str = Convert.ToString(factorial);
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] != '0')
                    break;
                if (ch[i] == '0')
                    ++result;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TrailingZeros(105423));
        }
    }
}
