﻿using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Usuario")]
        public string usuario { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [Display(Name = "Email")]
        public string email { get; set; }

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
        [Display(Name = "Fecha")]
        public DateTime fecha { get; set; }

        public Entrada() { }

        //Constructor parametrizado
        public Entrada(int id, string pelicula, enumSala sala, int fila, int butaca)
        {
            this.Id = id;
            this.pelicula = pelicula;
            this.sala = sala;
            this.fila = fila;
            this.butaca = butaca;
        }

        // Override del método ToString para mostrar los datos de la entrada (llamados implicitos a ToString de Pelicula y Sala)
        public override string ToString()
        {
            return $"Entrada para: {this.pelicula}\nSala: {this.sala}\nFila: {this.fila}\nButaca:{this.butaca}, \nFecha:{this.fecha}";
        }
    }

}
