using System;

namespace _16_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números inteiros:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            double resultado = Maior(num1, num2, num3);

            Console.WriteLine("O maior número digitado é: " + resultado);

        }

        static int Maior(int n1, int n2, int n3)
        {
            int maior;

            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }

            return maior;
        }
    }
}
