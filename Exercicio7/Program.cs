using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu Nome:");

            string nome = Console.ReadLine();




            Console.WriteLine("Insira o data de nascimento:");
            String dataAniversario = Console.ReadLine();

            DateTime.TryParse(dataAniversario, out DateTime dataAniversarioFormatada);

            int idade = DateTime.Today.Year - dataAniversarioFormatada.Year;

            Console.WriteLine($"Idade : {idade}");
  


            if (idade <= 19)
            {
                Console.WriteLine($"jovem");
            }
            else if (idade <= 59)
            {
                Console.WriteLine($"Adulto");

            }
            else  {

                Console.WriteLine($"Idoso");

            }
            Console.ReadLine();

        }
    }
}
