using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNT1
{
    public class Sala
    {
        // Propiedades autoimplementadas
        public int numero { get; set; }
        public enumSala tipo { get; set; }


        // Constructor parametrizado
        public Sala(int numero, enumSala descripcion)
        {
            this.numero = numero;
            this.descripcion = descripcion;
        }

        // Override del método ToString para mostrar el número de sala
        public override string ToString()
        {
            return $"Sala número: {this.numero}\nTipo: {this.descripcion}";
        }
    }
}
