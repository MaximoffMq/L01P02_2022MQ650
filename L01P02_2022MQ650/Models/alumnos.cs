using System.ComponentModel.DataAnnotations;

namespace L01P02_2022MQ650.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "El código del alumno es obligatorio")]
        [StringLength(10, ErrorMessage = "El código no puede superar los {1} caracteres")]
        public string? codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre del alumno es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los {1} caracteres")]
        public string? nombre { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Los apellidos del alumno son obligatorios")]
        [StringLength(50, ErrorMessage = "Los apellidos no pueden superar los {1} caracteres")]
        public string? apellidos { get; set; }

        [Display(Name = "DUI")]
        [Required(ErrorMessage = "El DUI es obligatorio")]
        public int dui { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }
    }
}
