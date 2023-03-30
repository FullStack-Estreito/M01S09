
namespace M01S09.Aula02.FluentApi.Models
{
    public class Compra
    {
       public int Id { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produtos { get; set; }

    }
}