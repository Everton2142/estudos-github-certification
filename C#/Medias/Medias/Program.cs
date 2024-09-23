//Este programa funciona como uma calculadora de média aritmética simples. Ao ser executado solicita que o usuário informe 4 notas e depois realiza o cálculo e apresenta os resultados.

using System;
using System.Globalization;

namespace Medias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis.
            double nota1, nota2, nota3, nota4, mediaAritmetica;

            Console.WriteLine("Olá! Insira quatro notas que o programa irá fazer o cálculo de uma média aritmética simples.");
            
            //Atribuição dos 4 valores que serão usados para o cálculo da média, cada um numa variável.
            Console.WriteLine("Primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Terceira nota: ");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quarta nota: ");
            nota4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo da média aritmética.
            mediaAritmetica = (nota1 + nota2 + nota3 + nota4) / 4;

            //Impressão do resultado do cálculo feito anteriormente.
            Console.WriteLine($"A média aritmética das quatro notas é de: {mediaAritmetica.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
    }
}
