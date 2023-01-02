using Core.Enums;

#nullable disable

namespace Core.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public StatusProduto Status { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
    }
}
