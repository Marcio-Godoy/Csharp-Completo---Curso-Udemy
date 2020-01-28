using System;

namespace _11_OpComparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine("A variavel a é menor a 10 ? :" + c1);
            Console.WriteLine("A variavel a é menor a 20 ? :" + c2);
            Console.WriteLine("A variavel a é maior a 10 ? :" + c3);
            Console.WriteLine("A variavel a é maior a 5 ? :" + c4);
            Console.WriteLine("----------------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 20;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine("A variavel a é menor ou igual a 10 ? :" + c5);
            Console.WriteLine("A variavel a é maior ou igual a 20 ? :" + c6);
            Console.WriteLine("A variavel a é igual a 10 ? :" + c7);
            Console.WriteLine("A variavel a é diferente que 10 ? :" + c8);

        }
    }
}
