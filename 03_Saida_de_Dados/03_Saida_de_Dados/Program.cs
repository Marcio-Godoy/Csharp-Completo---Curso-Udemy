using System;
using System.Globalization;

namespace _03_Saida_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARANDO VARIÁVEIS
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            //FIM DA DECLARAÇÃO DE VARIÁVEIS

            Console.WriteLine("Bom Dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("Qual é o genero: " + genero);
            Console.WriteLine("Qual é a idade: " + idade);
            Console.WriteLine("Qual é o saldo: " + saldo);
            Console.WriteLine("Qual é o nome: " + nome);
            Console.WriteLine("Qual é o saldo com duas casas decimais: " + saldo.ToString("F2")); //Delimitando o número de casas decimais
            Console.WriteLine("Qual é o saldo com quatro casas decimais: " + saldo.ToString("F4"));
            Console.WriteLine("Qual é o saldo com separação de digitos por ponto: " + saldo.ToString("F4", CultureInfo.InvariantCulture)); //CultureInfo.InvariantCulture serve para definir o valor com o ponto de decimais
            Console.WriteLine();

            // SAÍDA DE DADOS USANDO PLACEHOLDERS
            Console.WriteLine("SAÍDA DE DADOS COM PLACEHOLDERS");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //PlaceHolders
            Console.WriteLine();

            //SAÍDA DE DADOS USANDO INTERPOLAÇÃO
            Console.WriteLine("SAÍDA DE DADOS COM INTERPOLAÇÃO");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //Interpolação
            Console.WriteLine();

            //SAÍDA DE DADOS USANDO CONCATENAÇÃO
            Console.WriteLine("SAÍDA DE DADOS COM CONCATENAÇÃO"); //Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais ");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");

           


        }
    }
}
