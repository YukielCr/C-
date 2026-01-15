// Ejecusion del programa 
// dotnet run

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

            bool myBool=true;
            myBool=false;
            Console.WriteLine(myBool);


            Console.WriteLine($"El valor de mi entero {myInt} es y valor de mi bool {myBool}");


            const string MyConst="Mi constante";
            Console.WriteLine(MyConst);

            // Estructuras de Array

            var myArray= new String[] {"Yukiel","Kevin","Codere"};
            Console.WriteLine(myArray[2]);

            myArray[2]="36";
            Console.WriteLine(myArray[2]);

            // Uso de los diccionarios
            var myDictionary = new Dictionary<string, int>
            {
                {"Yukiel", 21},
                {"Arleth", 23}
            };

            Console.WriteLine(myDictionary["Arleth"]);

            // Esto es una lista estas no se repiten
            var mySet=new HashSet<string>{"Yukiel","Kevin","Codere","Yukiel"};
            Console.WriteLine(mySet);


            // El usa de las tuplas 
            var myTuple =("Yukiel","Kevin","Codere","Yukiel");
            Console.WriteLine(myTuple);

            // Bucles

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("-----------------------------------------");
            // recorerer estructuras que estna formadas
            foreach(var m in myArray)
            {
                Console.WriteLine(m);
            }

            foreach(var m in myDictionary)
            {
                Console.WriteLine(m);
            }


            //flujos


            int va=55;
            if (va == 5)
            {
                Console.WriteLine("Tas bien pedejo");
            }else if(va == 55){
                Console.WriteLine("Este chamo se fumo algo");
            }
            else
            {
                Console.WriteLine("TAs bien carnal hgjghj");
            }
            Console.WriteLine("54545454545454545454545");
            MyFuntion();
            MyFuntion();
            MyFuntion();
            MyFuntionWhithreturntDatos(55,55);
        }
        static void MyFuntion()
        {
            Console.WriteLine("Este es un mesaje de ayuda ");
        }


        static void MyFuntionWhithreturntDatos(int a, int b)
        {
            Console.WriteLine(a+b);
        }



    }
}




