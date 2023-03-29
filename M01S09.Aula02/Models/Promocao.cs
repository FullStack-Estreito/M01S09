using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M01S09.Aula02.Models
{
    [Table("Promocao")]
    public class Promocao
    {

        public Promocao()
        {
            this.Produtos = new List<PromocaoProduto>();
        }

        [Column("Id")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("Descricao")]
        [StringLength(100)]
        [Required]
        public string Descricao { get; set; }
        [Column("DataInicio")]
        [Required]
        public DateTime DataInicio { get; set; }
        [Column("DataTermino")]
        [Required]
        public DateTime DataTermino { get; set; }



        //propriedades publicas
        public virtual ICollection<PromocaoProduto> Produtos { get; set; }
    }
}
