using PilhaEstatica2021.Entidades;
using System;

namespace PilhaEstatica2021
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaEstatica p = new PilhaEstatica();

            p.Empilha(26);
            p.Empilha(2);
            p.Empilha(5);
            p.Empilha(16);
            var numeros = p.RetornaTodosElementos();
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            p.Desempilha();
            Console.WriteLine("No momento");
            numeros = p.RetornaTodosElementos();
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }

}

