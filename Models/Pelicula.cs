using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MVC_basico.Models
{
    public class Pelicula
    {
        // Propiedades autoimplementadas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Display(Name = "Género")]
        public enumGenero genero { get; set; }

        public Pelicula() { }

        // Constructor parametrizado
        public Pelicula(int id, string titulo, enumGenero genero)
        {
            this.Id = id;
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
