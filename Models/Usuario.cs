using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC_basico.Models
{
    public class Usuario
    {
        // Propiedades autoimplementadas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [Display(Name = "Email")]
        public string email { get; set; }

        public Usuario() { }

        // Constructor parametrizado
        public Usuario(int id, string nombre, string apellido, string email)
        {
            this.Id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }

        // Override del método ToString para mostrar el usuario
        public override string ToString()
        {
            return $"Nombre: {this.nombre}\nApellido: {this.apellido}\nEmail: {this.email}";
        }
    }
}
