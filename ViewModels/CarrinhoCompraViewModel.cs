
using MacBurgers.Models;

namespace MacBurgers.ViewModels
{
    public class CarrinhoCompraViewModel
    {   
        public CarrinhoCompra CarrinhoCompra { get; set; } = null!; 
        public decimal CarrinhoCompraTotal { get; set; }
    }
}