
using MacBurgers.Models;

namespace MacBurgers.Repositories.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}