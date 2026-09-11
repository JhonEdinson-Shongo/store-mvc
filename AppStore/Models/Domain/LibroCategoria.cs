using System.ComponentModel.DataAnnotations;

namespace AppStore.Models.Domain;

public class LibroCategoria
{
    [Key]
    public required int Id {get; set;}
    public required int LibroId { get; set; }
    public required Libro Libro { get; set; }
    public required int CategoriaId { get; set; }
    public required Categoria Categoria { get; set; }

}