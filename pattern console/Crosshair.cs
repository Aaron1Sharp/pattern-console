using System;

namespace pattern_console
{
    class Crosshair
    {
        public static void cross(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                        //empty square
                    if (i == 1 || i == count || j == 1 || j == count) 
                        Console.Write("X");        
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('_',count*3));     //string.Join????
            #region britain flag
                                                 //britain flag
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {                    
                                        //diagonally to the right
                    if (i == j)
                        Program.color_Output($"{j}", ConsoleColor.Red);
                    else
                        Program.color_Output(" ", ConsoleColor.Red);

                                                    //center
                    if (i == (count / 2) + 1 || j == (count / 2) + 1)
                        Program.color_Output($"{j}", ConsoleColor.Blue);
                    else
                        Program.color_Output(" ", ConsoleColor.Blue);

                                         //diagonally to the left
                    if ((i+j) == (count+1))
                        Program.color_Output($"{j}", ConsoleColor.Yellow);
                    else
                        Program.color_Output(" ", ConsoleColor.Yellow);                

                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
