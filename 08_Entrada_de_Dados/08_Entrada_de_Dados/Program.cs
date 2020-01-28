using System;

namespace _08_Entrada_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            //Split função para recortar a string
            string[] v = Console.ReadLine().Split(' '); //Pega cada caractere separado por espaço em branco
            string a = v[0]; //Vetor
            string b = v[1]; //Vetor
            string c = v[2]; //Vetor

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x); 
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //Split função para recortar a string
            //string s = Console.ReadLine();
            //string[] vet = s.Split(' '); //Pega cada caractere separado por espaço em branco
            //string p1 = vet[0]; //Vetor
            //string p2 = vet[1]; //Vetor
            //string p3 = vet[2]; //Vetor

        }
    }
}
