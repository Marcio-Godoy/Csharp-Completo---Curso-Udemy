using System;

namespace _07_ConversaoImplicita_e_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão Implicita de tipos
            float x = 4.5f; //Float = 4bytes
            double y = x; //Double = 8bytes
            Console.WriteLine(y);

            //Conversão Explicita de tipos
            double a;
            float b;

            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            //Casting
            double c;
            int d;

            c = 5.1;
            d = (int)c;
            Console.WriteLine(d);

            int e = 5;
            int f = 2;
            double resultado = (double) e / f; //Casting (double)
            Console.WriteLine(resultado);

        }
    }
}
