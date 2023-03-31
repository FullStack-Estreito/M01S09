namespace M01S09.Aula03.ExercicioFloricultura.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
