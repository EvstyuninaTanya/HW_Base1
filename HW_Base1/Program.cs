using System;

namespace HW_Base1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 0, 3, 11, 4, 5, 6, 13, 20, 44, 27 };

            int n = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    n += x[i];
                }

            }

            Console.WriteLine(n);
        }
    }
}
