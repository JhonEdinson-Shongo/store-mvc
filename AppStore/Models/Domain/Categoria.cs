using System.ComponentModel.DataAnnotations;

namespace AppStore.Models.Domain
{
    public class Categoria
    {
        [Key]
        public required int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; } =  [];
        public virtual ICollection<LibroCategoria> LibroCategorias { get; set; } =  [];
    }
}