using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int x = 2;
            for (int i = 0; i < 1000; i++)
            {
                if (i < 999)
                {
                    Console.Write(x + ", ");
                    if (i % 2 == 0)
                    {
                        x = -x;
                        x--;
                    }
                    else
                    {
                        x = -x;
                        x++;
                    }
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
