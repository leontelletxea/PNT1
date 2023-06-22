using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MVC_basico.Models
{
    public class Sala
    {
        // Propiedades autoimplementadas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Numero Sala")]
        public int numero { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Tipo Sala")]
        public enumSala tipo { get; set; }

        public Sala() { }

        // Constructor parametrizado
        public Sala(int numero, enumSala tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }

        // Override del método ToString para mostrar el número de sala
        public override string ToString()
        {
            return $"Sala número: {this.numero}\nTipo: {this.tipo}";
        }
    }

}
