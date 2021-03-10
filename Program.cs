using System;

namespace pract_3_eje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            Console.WriteLine("NUMEROS DEL 1 AL 10");
            do
            {
                x++;
                Console.WriteLine(x);
            } while (x < 10);

            Console.ReadKey();
        }
    }
}
