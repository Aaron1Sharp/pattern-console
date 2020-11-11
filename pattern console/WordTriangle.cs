using System;

namespace pattern_console
{
    class WordTriangle
    {
        public static void wordTriangle()
        {
            Console.WriteLine("Enter one word");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j <= i; j++)   
                    Console.Write(word[j]);
                
                Console.WriteLine("...");
            }
        }
    }
}
