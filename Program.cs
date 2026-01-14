using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Hola mundo
            Console.WriteLine("Hello, C#");

            /*
                Comentario de
                multiples lineas
            */

            string myString = "Este es un string";
            Console.WriteLine(myString);

            myString = "Este es una valir de cambio de la cadena";
            Console.WriteLine(myString);

            int myInt = 6;
            myInt = myInt + 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt+5);

            double myDouble =6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

        }
    }
}



