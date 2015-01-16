using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int x = 2;
            for (int i = 0; i < 10; i++)
            {
                if (i < 9)
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
