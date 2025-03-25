using System.ComponentModel.DataAnnotations;

namespace L01P02_2022MQ650.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Facultad")]
        [Required(ErrorMessage = "El nombre de la facultad es obligatorio")]
        [StringLength(100, ErrorMessage = "La facultad no puede superar los {1} caracteres")]
        public string? facultad { get; set; }
    }
}
