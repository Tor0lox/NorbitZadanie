using System;

internal class Zadanie2
{
    public static void PrintRomb(int n)
    {
        int mid = n / 2;

        for (int i = 0; i <= mid; i++)
        {
            for (int j = 0; j < mid - i; j++)
            {
                Console.Write(" ");
            }

            Console.Write("X");

            if (i > 0)
            {
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("X");
            }

            Console.WriteLine();
        }

        for (int i = mid - 1; i >= 0; i--)
        {
            for (int j = 0; j < mid - i; j++)
            {
                Console.Write(" ");
            }

            Console.Write("X");

            if (i > 0)
            {
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("X");
            }

            Console.WriteLine();
        }
    }
}