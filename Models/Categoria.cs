using System.ComponentModel.DataAnnotations;

namespace DockerBiblioteca.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}
