using System;

namespace _12_OpLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // && = E = AND
            // || = OU = OR
            // ! = NÃO = NOT

            bool c1 = 2 > 3 && 4 != 5; //Operador && 
            bool c2 = 2 > 3 || 4 != 5; //Operador || 
            bool c3 = !(2 > 3) &&  4 != 5; //Operador ! 

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine("---------------------");

            bool c4 = 10 < 5; 
            bool c5 = c1 || c2 && c3; 

            Console.WriteLine(c4);
            Console.WriteLine(c5);
        }
    }
}
