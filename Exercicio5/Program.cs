using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor");

            string primeiroValor = Console.ReadLine();
            decimal valor1Convertido = 0.0m;

            decimal.TryParse(primeiroValor, out valor1Convertido);

            Console.WriteLine("Informe o segundo valor");

            string segundoValor = Console.ReadLine();
            decimal valor2Convertido = 0.0m;

            decimal.TryParse(segundoValor, out valor2Convertido);

            decimal resultado = 0.0m ;



            Console.WriteLine($"ESCOLHA A OPERAÇÃO DESEJADA: ");
            Console.WriteLine($" 1 - SOMA.");
            Console.WriteLine($" 2 - SUBTRAÇÃO.");
            Console.WriteLine($" 3 - MULTIPLICAÇÃO.");
            Console.WriteLine($" 4 - DIVISÃO.");
            Console.WriteLine($" 5 - RESTO DA DIVISÃO.");

            int.TryParse(Console.ReadLine(), out int op);



            switch (op) {
                case 1:
                    resultado = valor1Convertido + valor2Convertido;
                    Console.WriteLine($"Resultado da soma de {valor1Convertido} + {valor2Convertido} = {resultado} ");
                    break;

                case 2:
                    resultado = valor1Convertido - valor2Convertido;
                    Console.WriteLine($"Resultado da subtração de  {valor1Convertido} - {valor2Convertido} = {resultado} ");
                    break;
                
                case 3:
                    resultado = valor1Convertido * valor2Convertido;
                    Console.WriteLine($"Resultado da multiplicação de  {valor1Convertido} * {valor2Convertido} = {resultado} ");
                    break;
                     
                case 4:
                    resultado = valor1Convertido / valor2Convertido;
                    Console.WriteLine($"Resultado da divisão de  {valor1Convertido} / {valor2Convertido} =  {resultado} ");
                    break;
                case 5:
                    resultado = valor1Convertido % valor2Convertido;
                    Console.WriteLine($"Resultado do resto da divisão é: {resultado} ");
                    break;

                default:
                    Console.WriteLine($"Operação não encontrada");

                    break;

            }

         



            //decimal soma = valor1Convertido + valor2Convertido;
            //Console.WriteLine($"Resultado da soma: {soma} ");

            //decimal subtracao = valor1Convertido - valor2Convertido;
            //Console.WriteLine($"Resultado da subtração: {subtracao} ");

            //decimal multiplicacao = valor1Convertido * valor2Convertido;
            //Console.WriteLine($"Resultado da multiplicação: {multiplicacao} ");

            //decimal divisao = valor1Convertido / valor2Convertido;
            //Console.WriteLine($"Resultado da divisao: {divisao} ");

            //decimal resultFinal = valor1Convertido % valor2Convertido;
  
            //Console.WriteLine($"Resto da divisão: {resultFinal} ");

            Console.ReadLine();
             }
    }
}
