using Core.Enums;

namespace Core
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public StatusProduto Status { get; set; }

        public int Quantidade { get; set; }

        public int IdCategoria { get; set; }

        public string Subcategoria { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
