using System;

namespace mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Ingrese el primero valor");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine ("{0} es mayor",a);
            }
            else 
                Console.WriteLine ("{0} es mayor", b);
        }
    }
}
