using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DockerBiblioteca.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaLanzamiento { get; set; }

        [Required]
        [ForeignKey("Autor")]
        public int? AutorId { get; set; }
        public Autor Autor { get; set; }

        [Required]
        [ForeignKey("Categoria")]
        public int? CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
