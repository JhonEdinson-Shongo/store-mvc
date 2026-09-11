using System.ComponentModel.DataAnnotations;

namespace AppStore.Models.Domain
{
    public class Libro
    {
        [Key]
        public required int Id { get; set; }
        public required string Titulo { get; set; }
        public string? CreateDate { get; set; }
        public string? Imagen { get; set; }
        public required string Autor { get; set; }

        public virtual ICollection<Categoria> Categorias { get; set; } =  [];
        public virtual ICollection<LibroCategoria> LibroCategorias { get; set; } =  [];
    }
}