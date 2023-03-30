
namespace M01S09.Aula02.FluentApi.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int Numero { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public virtual Cliente Cliente { get; set; }

    }
}