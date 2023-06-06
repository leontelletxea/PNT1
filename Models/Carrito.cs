using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_basico.Models
{
    public class Carrito
    {
        // Propiedades autoimplementadas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string nombre { get; set; }

        [Required]
        public string apellido { get; set; }

        [Required]
        [EmailAddress]
        public string correoElectronico { get; set; }

        public List<Entrada> carrito { get; set; }

        public Carrito() { }

        // Constructor parametrizado
        public Carrito(int id, string nombre, string apellido, string correoElectronico)
        {
            this.Id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correoElectronico = correoElectronico;
            this.carrito = new List<Entrada>();
        }

        // Constructor sobrecargado incluyendo el carrito
        public Carrito(int id, string nombre, string apellido, string correoElectronico, List<Entrada> carrito)
        {
            this.Id = id;
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
