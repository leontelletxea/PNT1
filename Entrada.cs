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
        public Pelicula pelicula { get; set; }
        public Sala sala { get; set; }
        public int fila { get; set; }
        public string butaca { get; set; }

        // Constructor parametrizado
        public Entrada(Pelicula pelicula, Sala sala, int fila, string butaca)
        {
            this.pelicula = pelicula;
            this.sala = sala;
            this.fila = fila;
            this.butaca = butaca;
        }

        // Override del método ToString para mostrar los datos de la entrada (llamados implicitos a ToString de Pelicula y Sala)
        public override string ToString()
        {
            return $"Entrada para: {pelicula}\nSala: {sala}\nFila: {fila}\nButaca:{butaca}";
        }
    }
}
