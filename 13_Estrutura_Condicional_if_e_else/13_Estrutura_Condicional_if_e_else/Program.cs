using System;

namespace _13_Estrutura_Condicional_if_e_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF COMPOSTO( if e else)
            Console.WriteLine("Digite um número inteiro:");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("O número digitado é PAR:");
            }
            else
            {
                Console.WriteLine("O número digitado é IMPAR:");
            }

            //IF ENCADEAMENTOS (if, else if e else)
            Console.WriteLine();
            Console.WriteLine("Qual é a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
