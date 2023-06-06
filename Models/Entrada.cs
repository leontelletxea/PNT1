﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MVC_basico.Models
{
    public class Entrada
    {
        // Propiedades autoimplementadas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Pelicula pelicula { get; set; }

        public Sala sala { get; set; }

        [Display(Name = "Fila")]
        public int fila { get; set; }

        [Display(Name = "Butaca")]
        public int butaca { get; set; }

        public Entrada() { }

        //Constructor parametrizado
        public Entrada(int id, Pelicula pelicula, Sala sala, int fila, int butaca)
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
            return $"Entrada para: {this.pelicula}\nSala: {this.sala}\nFila: {this.fila}\nButaca:{this.butaca}";
        }
    }

}