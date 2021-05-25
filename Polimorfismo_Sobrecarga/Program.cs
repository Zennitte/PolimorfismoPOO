using System;
using Polimorfismo_Sobrecarga.Classes;

namespace Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (var i = 0; i < f.lista.Length; i++)
            {
                Console.WriteLine("Digite um item para lista");
                f.lista[i] = Console.ReadLine();
            }

            Console.WriteLine("Mostrar sem argumentos");
            f.Mostrar();
            Console.WriteLine("");

            Console.WriteLine("Mostar com argumento int");
            f.Mostrar(2);
            Console.WriteLine("");

            Console.WriteLine("Mostar com argumento string");
            f.Mostrar("uva");
            Console.WriteLine("");
        }
    }
}
