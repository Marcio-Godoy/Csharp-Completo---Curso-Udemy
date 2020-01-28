using System;

namespace _02_Tipos_de_dados_basicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIANDO VARIAVEIS //
             
            bool Completo = false; //Verdadeiro ou Falso (Boolean)
            char Genero = '\u0041'; //Genero UNICODE por código
            byte n1 = 255; //Valor máximo suportado
            sbyte x = 127; //Valor máximo suportado
            int n2 = 126;
            int n3 = 2147483647;
            long n4 = 2147483648L; //Recomendado ao usar long colocar a letra L no final (Recomendação de boas práticas)
            float n5 = 4.5f;
            double n6 = 4.5;
            string Nome = "Marcio";
            object obj1 = "Marcio Godoy"; //Object: Tipo de dados GENERICO
            object obj2 = 4.5;

            // FIM DA CRIAÇÃO DE VARIAVEIS //

            Console.WriteLine(Completo);
            Console.WriteLine(Genero);
            Console.WriteLine("Tipo sbyte: " + x);
            Console.WriteLine("Tipo byte: " + n1);
            Console.WriteLine("Tipo int: " + n2);
            Console.WriteLine("Tipo int: " + n3);
            Console.WriteLine("Tipo long: " + n4);
            Console.WriteLine("Tipo float: " + n5);
            Console.WriteLine("Tipo double: " + n6);
            Console.WriteLine("Tipo String: " + Nome);
            Console.WriteLine("Tipo object: " + obj1);
            Console.WriteLine("Tipo object: " + obj2);
            Console.ReadLine();
            
        }
    }
}
