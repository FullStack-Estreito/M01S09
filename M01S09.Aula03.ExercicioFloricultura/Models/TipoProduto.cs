namespace M01S09.Aula03.ExercicioFloricultura.Models
{
    public class TipoProduto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
