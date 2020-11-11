using System;

namespace pattern_console
{
    class Wave
    {
       public static  void wave(int wave_lenght)
        {
            int wave_height = 5;
            for (int i = 1; i <= wave_height; i++)
            {
                for (int j = 1; j <= wave_lenght; j++)
                {
                    for (int k = 1; k <= wave_height; k++)
                    {
                        if (i == k || i + k == wave_height + 1) 
                            Console.Write("<>");                        
                        else
                            Console.Write("  ");                       
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
