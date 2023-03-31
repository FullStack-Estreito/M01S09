namespace M01S09.Aula03.ExercicioFloricultura.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Cliente_Id { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<PedidoProduto> Produtos { get; set; }
    }
}
