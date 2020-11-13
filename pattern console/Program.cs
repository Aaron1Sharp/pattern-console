using System;

namespace pattern_console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
             {
                Console.Clear();
                
                int number = input();
                choiceOptions(number);
                
                Console.WriteLine("restart ? ok");
                if (Console.ReadLine() != "ok")
                {
                    Console.WriteLine("leave");
                    break;
                }
             }
        }

        private static void choiceOptions(int number)
        {            
            Console.WriteLine("pattern = 2, 35, 50, 52,96  \nWave = 27. \nCase in word = 225.");
            switch (Console.ReadLine())
            {               
                case "2":
                    Square.pick_Side(number);
                    break;
                case "27":
                    Wave.wave(number);
                    break;
                case "35":
                    Tree._tree(number);
                    break;
                case "50":
                    InvertedTree._invertedTree(number);
                    break;
                case "52":
                    Arrow.pick_Side(number);
                    break;
                case "96":
                    Crosshair.cross(number);
                    break;
                case "225":
                    WordTriangle.wordTriangle();
                    break;
                default:
                    Console.WriteLine("Error... Try again");
                    break;
            }
        }

        private static int input()
        {
            int num = 0;
            bool whileStop = false;
            while (whileStop != true)
             {
                Console.WriteLine("insert the number.");
                string input = Console.ReadLine();

                if (int.TryParse(input, out num) == true)
                {
                    whileStop = true;
                    Console.Clear();
                    color_Output(input, ConsoleColor.Green);
                    Console.WriteLine(" = Conversion was successful.");
                }
                else
                {
                    color_Output(input, ConsoleColor.Green);
                    Console.WriteLine(" = Conversion failed.");
                }   

             }
            return num;
        }
        
        public static void color_Output(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor; 
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
