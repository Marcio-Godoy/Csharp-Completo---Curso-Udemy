using System;
using System.Globalization;

namespace _09_ExPraticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha): ");

            string[] vet = Console.ReadLine().Split(' '); //Criando o vetor vazio e usando o SPLIT para quebrar os caractere
            string ultimonome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("Os dados digitados foram:");
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimonome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
