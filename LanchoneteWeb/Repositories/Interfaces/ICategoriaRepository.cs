using LanchoneteWeb.Models;

namespace LanchoneteWeb.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
