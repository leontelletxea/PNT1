using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNT1
{
    public class Entrada
    {
        // Propiedades autoimplementadas
        public int id { get; set; }
        public Pelicula pelicula { get; set; }
        public Sala sala { get; set; }
        public int fila { get; set; }
        public int butaca { get; set; }

        // Constructor parametrizado
        public Entrada(int id, Pelicula pelicula, Sala sala, int fila, int butaca)
        {
            this.id = id;
            this.pelicula = pelicula;
            this.sala = sala;
            this.fila = fila;
            this.butaca = butaca;
        }

        // Override del método ToString para mostrar los datos de la entrada (llamados implicitos a ToString de Pelicula y Sala)
        public override string ToString()
        {
            return $"Entrada para: {this.pelicula}\nSala: {this.sala}\nFila: {this.fila}\nButaca:{this.butaca}";
        }
    }
}
