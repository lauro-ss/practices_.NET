using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaWeb.Models
{
    [Table("TB_PRODUTO")]
    public class ProdutoModel
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("Categoria")]
        [Display(Name = "Categoria")]
        public string? Categoria { get; set; }

        [Column("Quantidade")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Column("SubCategoria")]
        [Display(Name = "SubCategoria")]
        public string? SubCategoria { get; set; }
    }
}
