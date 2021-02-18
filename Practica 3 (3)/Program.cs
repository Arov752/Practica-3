using System;

namespace Practica_3__3_
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 10 * 10;
            Double b = 0;
            int c = 0;
            
            while (c < 11)
            {
                if (b == 0.00)
                {

                    Console.WriteLine(a);
                    
                    b = a % 2;
                    
                }

                a += 1;
                c += 1;
            }
            Console.ReadKey();
        }
    }
}
