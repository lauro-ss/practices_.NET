namespace Core
{

    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Subcategoria_1 { get; set; }

        public string? Subcategoria_2 { get; set; }

        public string? Subcategoria_3 { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
