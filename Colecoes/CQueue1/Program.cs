using System;
using System.Collections.Generic;
using System.Linq;

namespace CQueue1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fila");

            Queue<Pessoa> Pessoas = new Queue<Pessoa>();

            Pessoas.Enqueue(new Pessoa("Amanda", "25"));
            Pessoas.Enqueue(new Pessoa("Guilherme", "27"));
            Pessoas.Enqueue(new Pessoa("Natália", "30"));
            Pessoas.Enqueue(new Pessoa("Telma", "53"));
            Pessoas.Enqueue(new Pessoa("Marcos", "54"));

            Console.WriteLine($"A primeira pessoa da fila é: {Pessoas.Dequeue()}");

            Pessoas.Peek();

            Console.WriteLine($"O numero de pessoas na Fila é: {Pessoas.Count}");


            foreach (var item in Pessoas)
            {
                Console.WriteLine(item.ToString());
            }
        }


        public class Pessoa
        {
            public string Nome { get; set; }

            public string Idade { get; set; }

            public Pessoa(string nome, string idade)
            {
                Nome = nome;
                Idade = idade;
            }


            public override string ToString()
            {
                return $"Nome: {Nome} | Idade: {Idade}";
            }

        }
    }
}
