using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    public class Escritor : Persona
    {

        public string NombreArtistico { get; set; }

        public Escritor(string nombre, string apellidos, string identificacion, int edad, string nombreArtistico) :base(nombre,apellidos,identificacion,edad)
        {
            this.NombreArtistico = nombreArtistico;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Identificacion = identificacion;
            this.Edad = edad;
        }


        public override string getPersona()
            => $"Escritor conocido como {NombreArtistico} \n  Su nombre real es {Nombre} {Apellidos} \n Tiene {Edad} años"; 
    }
}
