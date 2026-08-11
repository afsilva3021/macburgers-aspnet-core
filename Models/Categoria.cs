using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacBurgers.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        
        [StringLength(100, ErrorMessage ="O Tamanho Maximo é de 100 Caracters")]
        [Required(ErrorMessage ="Informe o nome da Categoria")]
        [Display(Name="Nome")]
        public string? CategoriaName { get; set; }
        
        [StringLength(200, ErrorMessage ="O tamanho maximo é 200 caracters")]
        [Required(ErrorMessage ="Informe a descriçao da categoria")]
        [Display(Name ="Nome")]
        public string? Descricao { get; set; }

        public List<Lanche> ?Lanches { get; set; }
    }
}
