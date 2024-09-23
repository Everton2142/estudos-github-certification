//Programa que funciona como uma calculadora. Ao ser executado, será necessário que o usuário informe dois números e o restante é feito automaticamente.

using System;
using System.Globalization;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double numero1, numero2, adicao, subtracao, multiplicacao, divisao;

            Console.WriteLine("Olá! Insira dois números que a calculadora irá fazer automaticamente as quatro operações matemáticas básicas e exibir os resultados.");

            //Atribuição das variáveis numero1 e numero2, que serão usadas para a realização dos cálculos.
            Console.WriteLine("Primeiro número: ");
            numero1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Segundo número: ");
            numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Realização dos cálculos das quatro operações matemáticas básicas.
            adicao = numero1 + numero2;
            subtracao = numero1 - numero2;
            multiplicacao = numero1 * numero2;
            divisao = numero1 / numero2;

            //Impressão dos resultados calculados anteriormente.
            Console.WriteLine("\nOs resulados são:");
            Console.WriteLine($"\n{numero1.ToString("F2", CultureInfo.InvariantCulture)} + {numero2.ToString("F2", CultureInfo.InvariantCulture)} = {adicao.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{numero1.ToString("F2", CultureInfo.InvariantCulture)} - {numero2.ToString("F2", CultureInfo.InvariantCulture)} = {subtracao.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{numero1.ToString("F2", CultureInfo.InvariantCulture)} * {numero2.ToString("F2", CultureInfo.InvariantCulture)} = {multiplicacao.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{numero1.ToString("F2", CultureInfo.InvariantCulture)} / {numero2.ToString("F2", CultureInfo.InvariantCulture)} = {divisao.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
