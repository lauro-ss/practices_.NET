using System.ComponentModel;

namespace Core.Enums
{
    public enum StatusProduto
    {
        [Description("Normal")]
        Normal = 0,
        [Description("Vencido")]
        Vencido = 1,
        [Description("Danificado")]
        Danificado = 2,
        [Description("Em Falta")]
        EmFalta = 3
    }
}
