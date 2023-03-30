namespace M01S09.Aula02.FluentApi.Models
{
    public class PromocaoProduto
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int PromocaoId { get; set; }
        public virtual Produto Produto { get; set; }        
        public virtual Promocao Promocao { get; set; }
    }
}
