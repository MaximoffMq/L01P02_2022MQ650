using System.ComponentModel.DataAnnotations;

namespace L01P02_2022MQ650.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "El nombre del departamento es obligatorio")]
        [StringLength(50, ErrorMessage = "El departamento no puede superar los {1} caracteres")]
        public string? departamento { get; set; }
    }
}
