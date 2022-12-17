using System.ComponentModel.DataAnnotations;

namespace Core
{

    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(150, ErrorMessage = "O Nome só pode conter até 150 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "É obrigatório ter ao menos uma Subcategoria.")]
        [StringLength(150, ErrorMessage = "A Subcategoria só pode conter até 150 caracteres.")]
        public string Subcategoria_1 { get; set; } = string.Empty;

        [StringLength(150, ErrorMessage = "A Subcategoria só pode conter até 150 caracteres.")]
        public string? Subcategoria_2 { get; set; }

        [StringLength(150, ErrorMessage = "A Subcategoria só pode conter até 150 caracteres.")]
        public string? Subcategoria_3 { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
