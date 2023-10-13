using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string apellidos, string identifiacion, int edad)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Identificacion = identifiacion;
            this.Edad = edad;
        }

        public virtual string getPersona() => $"Su nombre es: {this.Nombre} {this.Apellidos} y tiene {this.Edad}";
    }
}
