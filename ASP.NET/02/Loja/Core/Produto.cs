using Core.Enums;

namespace Core
{

    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public StatusProduto Status { get; set; }

        public int? IdCategoria { get; set; }

        public Categoria? IdCategoriaNavigation { get; set; }
    }
}
