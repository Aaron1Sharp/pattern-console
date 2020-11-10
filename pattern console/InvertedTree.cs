using System;

namespace pattern_console
{
    partial class Program
    {
        static class InvertedTree
        {
            
            // 49 pattern
            public static void _invertedTree(int count)
            {
                int s = count * 2 - 1;
                int space = count - 1;

                for (int i = count; i >= 1; i--)
                {
                    for (int j = space; j >= i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= s; k++)
                    {
                        Console.Write(s);
                    }
                    s -= 2;
                    Console.WriteLine();
                }
            }
        }
    }
}
