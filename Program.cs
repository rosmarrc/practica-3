using System;

namespace pract_3_eje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y = 0;
            

            do
            {
                Console.Clear();
                Console.WriteLine("SUMA DE NUMEROS ENTEROS" + "\n");
                Console.WriteLine("Inserte un numero positivo: (digite 0 para terminar)");
                x = Convert.ToInt32(Console.ReadLine());
                y = x + y;

            } while (x != 0);

            Console.Clear();
            Console.WriteLine("SUMA DE NUMEROS ENTEROS" + "\n");
            Console.WriteLine("RESULTADO: " + y);
            Console.ReadKey();

        }
    }
}
