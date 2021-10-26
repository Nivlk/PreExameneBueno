using System;

namespace Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Escriba su edad: ");
            edad = int.Parse(Console.ReadLine());
            if(edad => 18 && edad <= 25){
                Console.WriteLine("La edad se encuentra en un rango de 18 a 25");
            }
            else if(edad<18){
                Console.WriteLine("La edad es menor a 18");
            }
            else{
                Console.WriteLine("La edad es mayor a 25");
            }
            Console.ReadKey();
        }
    }
}