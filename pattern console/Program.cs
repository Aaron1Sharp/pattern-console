using System;

namespace pattern_console
{
    partial class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                choiceOptions();
                Console.WriteLine("restart ? ok");
               string choise = Console.ReadLine();

                if (choise != "ok")
                {
                    Console.WriteLine("leave");
                    break;
                }
            }
        }

        private static void choiceOptions()
        {
            byte num = 5;
            Console.WriteLine("Enter the number you want to work with (Up to 10)!");
            
            Console.WriteLine("pattern 35 or 49?");
            string option = Console.ReadLine();
            switch (option)
            {
                case "35":
                    Tree._tree(num);
                    break;
                case "49":
                    InvertedTree._invertedTree(num);
                    break;
                default:
                    Console.WriteLine("Error... 35 or 49/");
                    break;
            }
        }
    }
}
