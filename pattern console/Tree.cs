using System;

namespace pattern_console
{
    partial class Program
    {
        static class Tree
        {
            //35 pattern
           public static void _tree(byte count)
            {
                byte z = 1;
                for (int i = 0; i < count; i++)
                {
                    for (int j = count - 1; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write(z - i);
                    }
                    z += 2;
                    Console.WriteLine();
                }          
            }
        }      
    }
}
