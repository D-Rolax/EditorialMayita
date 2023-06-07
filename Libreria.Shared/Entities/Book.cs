using System.ComponentModel.DataAnnotations;

namespace Libreria.Shared.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Name { get; set; } = null!;
        [Display(Name = "Nivel")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string level { get; set; } = null!;
        [Display(Name = "Curso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Course { get; set; } = null!;
        [Display(Name = "Materia")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Subject { get; set; } = null!;
        [Display(Name = "Año de Edición")]
        public DateTime EditionYear { get; set; }
        [Display(Name = "Fecha de Registro")]
        public DateTime RegistrationDate { get; set; }
        [Display(Name = "Estado")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string State { get; set; } = null!;
    }
}
