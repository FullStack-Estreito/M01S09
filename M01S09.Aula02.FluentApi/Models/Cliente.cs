
namespace M01S09.Aula02.FluentApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco EnderecoDeEntrega { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
    }
}