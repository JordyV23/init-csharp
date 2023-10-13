using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    class clsLibro
    {

        //Esta es una manera simplificada de declarar getters y setters
        // (No es muy utilizado)
        private string _nombre;
        public string Nombre { get; set; }



        //Esta es otra manera de declarar getter y setter
        private string _autor;
        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }


        //Esta es otra manera de declarar getters y setters
        private int _cantidadPaginas;
        public string CantidadPaginas
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public clsLibro(string nombre, string autor, int cantidadPaginas )
        {
            this._nombre = nombre;
            this._autor = autor;
            this._cantidadPaginas = cantidadPaginas;
            this.Nombre = nombre;
        }

        public string GetDescripcion()
        {
            return $" El libro {_nombre} \n Fue escrito por: {_autor} \n Tiene {_cantidadPaginas} paginas en total";
        }

        //Funcion de flecha
        public string GetDescripcionFlecha() => $" El libro {_nombre} \n Fue escrito por: {_autor} \n Tiene {_cantidadPaginas} paginas en total";





    }
}
