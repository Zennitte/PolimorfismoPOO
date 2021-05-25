using System;
using Polimorfismo_Override.Classes;

namespace Polimorfismo_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan m = new MegaMan();
            
            Zero z = new Zero();
            
            Console.WriteLine("MegaMan: ");
            Console.WriteLine(m.Correr());
            Console.WriteLine(m.Pular());

            Console.WriteLine("");

            Console.WriteLine("Zero: ");
            Console.WriteLine(z.Correr());
            Console.WriteLine(z.Pular());
        }
    }
}
