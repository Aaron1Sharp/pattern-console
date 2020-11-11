using System;

namespace pattern_console
{
    class Square
    {
        public static void pick_Side(int count)
        {

            Console.WriteLine("Start with a smaller default, to start with a larger number enter = more " +
                                            "\nsmall-left default\n\t12345\n\t12345\n\t12345\n\t12345\n\t12345");
            string selected = Console.ReadLine();
            Program.consColor(selected);

            if (selected == "more")
            {
                Console.WriteLine("You chose the more. If you want to start from the top... Enter = top. Default = left");
                selected = Console.ReadLine();
                Program.consColor(selected);
                _squareStartWithMore(count, selected);
            }

            else
            {
                Console.WriteLine("you chose the smallest. If you want to start from the top... Enter = top. Default = left");
                selected = Console.ReadLine();
                Program.consColor(selected);
                _squareStartWithLess(count, selected);
            }
        }

        static void _squareStartWithMore(int count, string select)
        {
            if (select == "left")
                larger_Number_On_The_Left();
            else
                higher_Number_On_Top();

            #region large num

            void larger_Number_On_The_Left()// PATTERN 7                         
            {
                for (int i = count; i >= 1; i--)
                {                                                          
                    for (int j = count; j >= 1; j--)                                                                
                        Console.Write(j);                       
                            
                    Console.WriteLine();
                }
            }

            void higher_Number_On_Top() //PATTERN 6                          
            {
                for (int i = count; i >= 1; i--)
                {
                    for (int j = 1; j <= count; j++)
                        Console.Write(i);
                            
                    Console.WriteLine();
                }
            }

            #endregion
        }
        static void _squareStartWithLess(int count, string select)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    if (select == "top")
                        Console.Write(i); //PATTERN 2
                    else
                        Console.Write(j); //PATTERN 3
                }
                Console.WriteLine();
            }
        }

    }
}
