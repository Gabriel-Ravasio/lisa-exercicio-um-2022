using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o ano de nascimento:");
            string anoN = Console.ReadLine();
            int anoNConvertido = 0;

            int.TryParse(anoN, out anoNConvertido);

            int anoA = DateTime.Today.Year;

            int idade = anoA - anoNConvertido;

            Console.WriteLine($"Idade : {idade}");
            Console.ReadLine();
        }
    }
}
