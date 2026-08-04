using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MacBurgers.Models;

namespace MacBurgers.Repositories.Interface
{
    public interface ILanchesRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche? GetLancheById(int LancheId);
    }
}