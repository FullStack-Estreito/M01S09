
namespace M01S09.Aula02.FluentApi.Models
{
    public class Produto
    {
       public int Id { get; set; }
       public string Nome { get; set; }
       public string Categoria { get; set; }
       public decimal PrecoUnitario { get; set; }

        //propriedade de navegação
        public virtual ICollection<PromocaoProduto> Promocoes { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }

    }
}