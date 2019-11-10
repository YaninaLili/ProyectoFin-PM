using System.ComponentModel.DataAnnotations;

namespace ProyectoFin_PM.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Url de Foto")]
        public string Foto { get; set; }
        
        [Required]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Display(Name="Tiempo")]
        public string Tiempo { get; set; }

        [Required]
        [Display(Name="Precio")]
        public float Precio { get; set; }

        [Display(Name="Descripción")]
        public string Descripcion { get; set; }
    }
}