using System;

namespace pattern_console
{
     class Arrow
     {
        public static void pick_Side(int count)
        {
            Console.WriteLine("turn left? enter = left. Default Right");
            string selected = Console.ReadLine();
            Program.color_Output(selected, ConsoleColor.Green);

            if (selected == "left")
            {
                Console.WriteLine("You chose = left");
                arrowLeft(count);
            }
            else
            {
                Console.WriteLine("you chose = Right");
                arrowRight(count);
            }
        }

        static void  arrowRight(int input)
        {
            for (int i = input; i >= -input; i--)   //54
            {
                for (int j = 1; j <= Math.Abs(i); j++)
                    Console.Write(" ");

                for (int k = input; k >= Math.Abs(i); k--)
                    Console.Write(k);

                Console.WriteLine();
            }
        }
        static void arrowLeft(int input)
        {
            for (int i = input; i >= -input; i--)   //60
            {
                for (int j = input; j >= Math.Abs(i); j--)               
                    Console.Write("*");
                
                Console.WriteLine();
            }
        }
     }
}
