using System.ComponentModel.DataAnnotations;

namespace L01P02_2022MQ650.Models
{
    public class materias
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Materia")]
        [Required(ErrorMessage = "El nombre de la materia es obligatorio")]
        [StringLength(100, ErrorMessage = "La materia no puede superar los {1} caracteres")]
        public string? materia { get; set; }

        [Display(Name = "Unidades Valorativas")]
        [Required(ErrorMessage = "Debe ingresar las unidades valorativas")]
        public int unidades_valorativas { get; set; }

        [Display(Name = "Estado")]
        [StringLength(1, ErrorMessage = "El estado debe ser un solo carácter")]
        public string? estado { get; set; }
    }
}
