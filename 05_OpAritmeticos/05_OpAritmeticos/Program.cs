using System;

namespace _05_OpAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10 / 8;
            double n5 = 10.0 / 8;
            double a = 1.0, b = -3.0, c = -4.0;          
            //double delta = b * b -4.0 * a * c;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; //Usando função para realizar o cálculo
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("O resultado é: " + n1);
            Console.WriteLine("O resultado é: " + n2);
            Console.WriteLine("O resultado é: " + n3);
            Console.WriteLine("O resultado da divisão é: " + n4);
            Console.WriteLine("O resultado da divisão é: " + n5);
            Console.WriteLine("O delta é: " + delta);
            Console.WriteLine("O resultado da primeira raiz da equação é: " + x1);
            Console.WriteLine("O resultado da segunda raiz da equação é: " + x2);

        }
    }
}
