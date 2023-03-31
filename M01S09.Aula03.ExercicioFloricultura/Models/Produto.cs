namespace M01S09.Aula03.ExercicioFloricultura.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Tipo_Id { get; set; }
        public int Estoque_Id { get; set; }


        public virtual Estoque Estoque { get; set; }
        public virtual TipoProduto Tipo { get; set; }

        public virtual ICollection<PedidoProduto> Pedidos { get; set; }
    }
}
