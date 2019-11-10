using System.ComponentModel.DataAnnotations;

namespace ProyectoFin_PM.Models
{
    public class Producto
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name="Url de Foto")]
        public string Foto { get; set; }

        [Required]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name="Marca")]
        public string Marca { get; set; }

        [Required]
        [Display(Name="Medida (gr./ml.)")]
        public float Medida { get; set; }

        [Required]
        [Display(Name="Precio")]
        public float Precio { get; set; }

        [Display(Name="Descripción")]
        public string Descripcion { get; set; }
    }
}