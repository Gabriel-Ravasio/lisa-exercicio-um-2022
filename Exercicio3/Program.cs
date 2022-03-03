using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quilometragem rodada: ");
            string kmRodado = Console.ReadLine();
            decimal kmConvertido = 0.0m;

            Console.WriteLine("Informe a quantidade de litros utilizada: ");
            string litrosGastos = Console.ReadLine();
            decimal litrosConvertido = 0.0m;

            decimal.TryParse(kmRodado, out kmConvertido);
            decimal.TryParse(litrosGastos, out litrosConvertido);


            decimal mediaGasta= kmConvertido / litrosConvertido;

            Console.WriteLine($"Seu automovel fez: {mediaGasta} km rodado por litro gasto. ");

        }
    }
}
