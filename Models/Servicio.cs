using System.ComponentModel.DataAnnotations;

namespace ProyectoFin_PM.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        public string Foto { get; set; }
        
        [Required]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name="Tipo")]
        public string Tipo { get; set; }

        [Required]
        [Display(Name="Tiempo")]
        public string Tiempo { get; set; }

        [Required]
        [Display(Name="Precio")]
        public float Precio { get; set; }

        [Display(Name="Descripción")]
        public string Descripcion { get; set; }
    }
}