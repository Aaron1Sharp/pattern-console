using System;

namespace pattern_console
{
    class InvertedTree
    {            
        // 50 pattern
        public static void _invertedTree(int count)
        {
            int s = (count * 2) - 1;

            for (int i = count; i >= 1; i--)
            {
                for (int j = count - 1; j >= i; j--)
                    Console.Write(" ");      
                
                for (int k = s; k >= 1; k--)
                    Console.Write(i);
                
                s -= 2;
                Console.WriteLine();
            }
        }
    }
    
}
