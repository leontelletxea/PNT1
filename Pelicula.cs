using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNT1
{
    public class Pelicula
    {
        // Propiedades autoimplementadas
        public int id { get; set; }
        public string titulo { get; set; }
        public enumGenero genero { get; set; }

        // Constructor parametrizado
        public Pelicula(int id, string titulo, enumGenero genero)
        {
            this.id = id;
            this.titulo = titulo;
            this.genero = genero; 
        }

        // Override del método ToString para mostrar el número de sala
        public override string ToString()
        {
            return $"Titulo: {titulo}\nGenero: {genero}";
        }
    }
}
