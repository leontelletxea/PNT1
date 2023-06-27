using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace MVC_basico.Models
{
    public class Entrada
    {
        // Propiedades autoimplementadas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual int peliculaId { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Pelicula")]
        public string pelicula { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Sala")]
        public enumSala sala { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Range(1, 100, ErrorMessage = "El valor debe estar entre 1 y 100.")]
        [Display(Name = "Fila")]
        public int fila { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Range(1, 100, ErrorMessage = "El valor debe estar entre 1 y 100.")]
        [Display(Name = "Butaca")]
        public int butaca { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha { get; set; }

        //agregar apellido nombre y mail 1 persona 1 entrada

        public Entrada() { }

        //Constructor parametrizado
        public Entrada(int id, int peliculaId, enumSala sala, int fila, int butaca)
        {
            this.Id = id;
            this.peliculaId = peliculaId;
            this.sala = sala;
            this.fila = fila;
            this.butaca = butaca;
        }

        // Override del método ToString para mostrar los datos de la entrada (llamados implicitos a ToString de Pelicula y Sala)
        public override string ToString()
        {
            return $"Entrada para: {this.peliculaId}\nSala: {this.sala}\nFila: {this.fila}\nButaca:{this.butaca}, \nFecha:{this.fecha}";
        }
    }

}
