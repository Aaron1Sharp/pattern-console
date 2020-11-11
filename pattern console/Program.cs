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
                if (Console.ReadLine() != "ok")
                {
                    Console.WriteLine("leave");
                    break;
                }
            }
        }

        private static void choiceOptions()
        {
                int num = 0;
                string input;
                bool whilestop = false;

            while (whilestop != true)
             {

                Console.WriteLine("insert the number.");
                input = Console.ReadLine();

                    if (int.TryParse(input, out num) == true)
                    {
                        whilestop = true;
                        Console.WriteLine("Conversion was successful.");
                        consColor(input);
                    }
                    else
                    {
                        Console.WriteLine("Conversion failed.");
                        consColor(input);
                    }
             }            
            Console.WriteLine("pattern 2, 35, 49?");
            string option = Console.ReadLine();
            consColor(option);
            switch (option)
            {
                case "2":
                    Square.pick_Side(num);
                    break;
                case "35":
                    Tree._tree(num);
                    break;
                case "49":
                    InvertedTree._invertedTree(num);
                    break;
                default:
                    Console.WriteLine("Error... Try again");
                    break;
            }
        }
       static public void consColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
