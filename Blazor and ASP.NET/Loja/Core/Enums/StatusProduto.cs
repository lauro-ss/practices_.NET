using System.ComponentModel;

namespace Core.Enums
{
    public enum StatusProduto
    {
        [Description("Normal")]
        Normal = 1,
        [Description("Vencido")]
        Vencido = 2,
        [Description("Danificado")]
        Danificado = 3,
        [Description("Esgotado")]
        Esgotado = 4
    }
}
