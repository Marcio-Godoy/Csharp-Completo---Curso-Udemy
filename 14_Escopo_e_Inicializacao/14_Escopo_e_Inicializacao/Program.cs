using System;

namespace _14_Escopo_e_Inicializacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor do preço do produto:");

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0;

            if(preco > 100.00) {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}
