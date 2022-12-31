using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(150, ErrorMessage = "O Nome só pode conter até 150 caracteres.")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        [RegularExpression("^[0-9]{1,10}(\\,[0-9]{0,2})*", ErrorMessage = "Valor inválido")]
        public decimal Valor { get; set; } = 0.0M;

        [Required(ErrorMessage = "O campo Status é obrigatório.")]
        [Range(1, 100, ErrorMessage = "O campo Status é obrigatório.")]
        public StatusProduto Status { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório.")]
        [RegularExpression("[0-9]{1,10}", ErrorMessage = "Quantidade inválida")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O campo Categoria é obrigatório.")]
        [RegularExpression("[1-9]{1,10}", ErrorMessage = "O campo Categoria é obrigatório.")]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "O campo Subcategoria é obrigatório.")]
        public string Subcategoria { get; set; } = string.Empty;

        public Categoria? Categoria { get; set; }
    }
}
