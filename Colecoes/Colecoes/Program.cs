using System;
using System.Collections.Generic;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista");

            List<string> Animais = new List<string>();

            Animais.Add("Cavalo");
            Animais.Add("Borboleta");
            Animais.Add("Salamandra");
            Animais.Add("Esquilo");

            Animais.Insert(1, "Jabuti");

            Animais.Remove(new string("Cavalo"));

            Animais.RemoveAt(1);

            foreach (string animal in Animais)
            {
                Console.WriteLine($"Aqui está o animal: {animal}");
            }

        }
    }
}
