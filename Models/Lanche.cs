using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MacBurgers.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O Nome do lanche deveser informado")]
        [Display(Name = "Nome do lanche")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2}")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição curta do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
        public string? DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição detalhada do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
        public string? DescricaoDetalhada { get; set; }

        [Required(ErrorMessage ="Informe o preço do lanche")]
        [Display(Name ="Preco")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entra 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name ="O Caminho Image Normal")]
        [StringLength(255, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string? ImagemUrl { get; set; }

        [Display(Name ="O Caminho da imagem miniatura")]
        [StringLength(255, ErrorMessage ="O {0} deve ter no máximo {1} caracters")]
        public string? ImagemThubnailUrl { get; set; }

        [Display(Name = "Preferido")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name ="Estoque")]
        public bool EmEstoque { get; set; }

        [Display(Name ="Data de Inclusão")]
        public DateTime DataDeCricao { get; set; }
        [Display(Name ="Data de Atualização")]
        public DateTime Atualizacao { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria ?Categoria { get; set; }
    }
}
