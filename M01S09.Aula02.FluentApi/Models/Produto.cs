
namespace M01S09.Aula02.FluentApi.Models
{
    public class Produto
    {
        public int Id { get; set; }

       public string Nome { get; set; }

       public string Categoria { get; set; }

       public decimal PrecoUnitario { get; set; }

        public ICollection<PromocaoProduto> Promocoes { get; set; }

        //propriedade de navegação
        public virtual ICollection<Compra> Compras { get; set; }

    }
}