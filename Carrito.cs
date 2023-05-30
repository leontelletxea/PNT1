using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNT1
{
    public class Carrito
    {
        // Propiedades autoimplementadas
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correoElectronico { get; set;}
        public List<Entrada> carrito { get; set; }

        // Constructor parametrizado
        public Carrito(int id, string nombre, string apellido, string correoElectronico)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;    
            this.correoElectronico = correoElectronico;
            this.carrito = new List<Entrada>();
        }

        // Constructor sobrecargado incluyendo el carrito
        public Carrito(int id, string nombre, string apellido, string correoElectronico, List<Entrada> carrito)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correoElectronico = correoElectronico;
            this.carrito = carrito;
        }

        // Override del método ToString para mostrar el carrito (llamado explicito al ToString de Entrada)
        public override string ToString()
        {
            var ret = $"Carrito de: {this.nombre} {this.apellido}\nCorreo Electronico: {this.correoElectronico}\n";

            foreach (var item in carrito)
            {
                ret += item.ToString() + "\n";
            }

            return ret;
        }
    }
}
