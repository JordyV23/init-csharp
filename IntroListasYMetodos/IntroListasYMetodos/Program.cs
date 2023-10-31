using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroListasYMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            ArreglosStackCollection();

            void ArreglosYListas ()
            {
                // Array
                string[] nombres = { "Juan", "Mario", "Fernanda" };
                Console.WriteLine(nombres[0]);

                //Lista
                List<string> namesList = new List<string>();

                //Agregar data a list desde un array
                namesList.AddRange(nombres);
                Console.WriteLine(namesList);

                //Agregar un elemento
                namesList.Add("Pablo");

                //Contar Elementos
                Console.WriteLine($"Cantidad de nombres: { namesList.Count }");

                ImprimirLista(namesList);

                namesList.RemoveAt(3);

                ImprimirLista(namesList);

                Console.ReadKey();


                void ImprimirLista(List<string> lista)
                {
                    foreach (var nombre in lista)
                    {
                        Console.WriteLine(nombre);
                    }
                }
            }

            void ArreglosLinkedList() 
            {
                string[] songs =
                {
                    "Riptide",
                    "Mein Hertz Brent",
                    "Miracle",
                    "Demons",
                    "The Resistance",
                    "Camino Al Sur"
                };

                LinkedList<string> canciones = new LinkedList<string>(songs);

                canciones.AddFirst("Believer");
                canciones.AddLast("PMVR");

                foreach (string obj in canciones)
                {
                    Console.WriteLine(obj);
                }

                Console.ReadKey();
            }

            void ArreglosStackCollection()
            {
                Stack<string> miStack = new Stack<string>();
                miStack.Push("Uno");
                miStack.Push("Dos");
                miStack.Push("Tres");
                miStack.Push("Cuatro");
                miStack.Push("Cinco");

                foreach (string element in miStack) 
                {
                    Console.WriteLine(element);
                }

                //Obtener primer elemento
                Console.WriteLine(miStack.Peek());

                //Eliminar un elemento
                Console.WriteLine(miStack.Pop());
                Console.ReadKey();
            }
        }
    }
}
