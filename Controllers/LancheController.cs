
using MacBurgers.Repositories.Interface;
using MacBurgers.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MacBurgers.Controllers
{
   
    public class LancheController : Controller
    {
        private readonly ILanchesRepository _lancheRepository;

        public LancheController(ILanchesRepository  lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
           var lanchesListViewsModel = new LancheListViewModel();
           lanchesListViewsModel.Lanches = _lancheRepository.Lanches;
           lanchesListViewsModel.CategoriaAtual = "Categoria Atual";

           return View(lanchesListViewsModel);
        }

    }
}