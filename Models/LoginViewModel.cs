using System.ComponentModel.DataAnnotations;

namespace ProyectoFin_PM.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name="Correo Electrónico")]
        public string Correo {get;set;}

        [Required]
        [Display(Name="Contraseña")]
        [DataType(DataType.Password)]
        public string Password  {get;set;}
    }
}