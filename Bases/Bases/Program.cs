using System;

namespace Bases
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Este es 
                un comentario 
                        multilinea
             */

            //Este es un comentario en linea

            string nombre = "Jordy";

            //Con var se asignan valores implicitos
            var apellido = "Vargas";

            //Tipados
            int entero = 100;

            //----
            //Los valores para numeros no enteros, se pueden usar los siguientes
            //Los float deben de llevar la f
            float flotante = 36.23f;
            double doubles = 36.94;
            //Los deciman deben de llevar la m
            decimal valorDecima = 450.567m;
            //----

            //Tiene como maximo 255
            byte myLittleNumber = 255;

            bool isLearning = true;

            char caracter = 'J';


            const int constante = 10;

            Console.WriteLine("Hello World! Atte: " + nombre );
            Console.WriteLine("Ingrese un numero");
            //Leer variables por consola
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero");
            int num2 = int.Parse(Console.ReadLine());

            //Operadores Aritmeticos
            int suma = num1 + num2;
            int resta = num1 - num2;
            int multi = num1 * num2;
            var division = num1 / num2;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta} ");
            Console.WriteLine($"Multi: {multi}");
            Console.WriteLine($"Division: {division}");
        }
    }
}
