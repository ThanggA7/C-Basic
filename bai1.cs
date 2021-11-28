using System;

namespace Bai_Tap
{
    class Program
    {
        static void Main(string[] args)
        {
        int x;
        int y;
        for (x = -10; x <= 10; x++)
        {
            y = x*x - 2*x +1;

            Console.WriteLine(y);
            
        }
        }
    }
}