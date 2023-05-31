using LanchoneteWeb.Models;

namespace LanchoneteWeb.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche>Lanches { get; }
        IEnumerable<Lanche>LanchesPreferidos { get; }
        Lanche GetLancheById(int id);
    }
}
