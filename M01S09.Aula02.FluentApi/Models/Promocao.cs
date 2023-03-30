
namespace M01S09.Aula02.FluentApi.Models
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }

        //propriedade de navegação
        public ICollection<PromocaoProduto> Produtos { get; set; }

        public Promocao()
        {
            Produtos = new List<PromocaoProduto>();
        }
    }
}
