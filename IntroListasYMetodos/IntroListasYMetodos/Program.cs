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
    
            // Array
            string[] nombres = { "Juan","Mario", "Fernanda"};
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

            ImprimirLista( namesList );

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
    }
}
