using System;

namespace Bases
{
    class Program
    {
        static void Main(string[] args)
        {

            clsLibro donQuijote = new clsLibro("Don Quijote de la Mancha", "Miguel de cervante", 809);
            //Manera Nueva:
            clsLibro elPeregrino = new("El Peregrino", "Paulo Coelho", 120);


            Console.WriteLine(donQuijote.GetDescripcion() + "\n ");
            Console.WriteLine(donQuijote.Nombre);
            Console.WriteLine(elPeregrino.GetDescripcion());
            Console.WriteLine(elPeregrino.GetDescripcionFlecha());

            Escritor TiaPanchita = new Escritor("Carmen", "Lira", "123456789", 73, "Tia Panchita" );
            Console.WriteLine(TiaPanchita.getPersona());

        }


    }
}
