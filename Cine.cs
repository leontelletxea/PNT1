using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNT1
{
    public class Cine
    {
        // Propiedad autoimplementada
        public List<Pelicula> cartelera { get; set; }

        // Constructor por defecto
        public Cine()
        {
            this.cartelera = new List<Pelicula>();
        }

        // Constructor parametrizado
        public Cine(List<Pelicula> cartelera)
        {
            this.cartelera = cartelera;
        }

        // Override del método ToString para mostrar el listado de peliculas
        public override string ToString()
        {
            var ret = "Cartelera:\n";

            foreach (var item in cartelera)
            {
                ret += item.ToString() + "\n";
            }

            return ret;
        }
    }
}
