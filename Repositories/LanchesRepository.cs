using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MacBurgers.Context;
using MacBurgers.Models;
using MacBurgers.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace MacBurgers.Repositories
{
    public class LanchesRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;

        public LanchesRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido == true);

        public Lanche? GetLancheById(int lancheId)
        {
            
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}