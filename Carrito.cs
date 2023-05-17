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
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correoElectronico { get; set;}
        public List<Entrada> carrito { get; set; }

        // Constructor parametrizado
        public Carrito(string nombre, string apellido, string correoElectronico)
        {
            this.nombre = nombre;
            this.apellido = apellido;    
            this.correoElectronico = correoElectronico;
            this.carrito = new List<Entrada>();
        }

        // Constructor sobrecargado incluyendo el carrito
        public Carrito(string nombre, string apellido, string correoElectronico, List<Entrada> carrito)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correoElectronico = correoElectronico;
            this.carrito = carrito;
        }

        // Override del método ToString para mostrar el carrito (llamado explicito al ToString de Entrada)
        public override string ToString()
        {
            var ret = $"Carrito de: {nombre} {apellido}\nCorreo Electronico: {correoElectronico}\n";

            foreach (var item in carrito)
            {
                ret += item.ToString() + "\n";
            }

            return ret;
        }
    }
}
