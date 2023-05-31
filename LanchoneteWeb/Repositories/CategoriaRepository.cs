using LanchoneteWeb.Context;
using LanchoneteWeb.Models;
using LanchoneteWeb.Repositories.Interfaces;

namespace LanchoneteWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
