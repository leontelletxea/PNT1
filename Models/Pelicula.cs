using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC_basico.Models
{
    public class Pelicula
    {
        // Propiedades autoimplementadas
        [Key]
        public int id { get; set; }

        [Required]
        public string titulo { get; set; }

        [Display(Name = "Género")]
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
            return $"Titulo: {this.titulo}\nGenero: {this.genero}";
        }
    }

}
