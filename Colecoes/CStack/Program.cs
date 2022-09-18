using System;
using System.Collections.Generic;
using System.Linq;

namespace CStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Livros = new Stack<string>();

            Livros.Push("Harry Potter e o Enigma do Príncipe");
            Livros.Push("A Insustentável Leveza do Ser");
            Livros.Push("A Coragem de Ser Imperfeito");

            Console.WriteLine($"O primeiro livro da pilha é: {Livros.Peek()}");

            Livros.Pop();

            Console.WriteLine($"A quantidade de livros restantes na pilha é: {Livros.Count()}");

            foreach (String livro in Livros)
            {
                Console.WriteLine($"Os livros são: {livro}");
            }

        }
    }
}
