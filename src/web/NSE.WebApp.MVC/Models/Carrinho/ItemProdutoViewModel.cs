namespace NSE.WebApp.MVC.Models
{
    public class ItemProdutoViewModel
    {
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; } = String.Empty;
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string Imagem { get; set; } = String.Empty;
    }
}
