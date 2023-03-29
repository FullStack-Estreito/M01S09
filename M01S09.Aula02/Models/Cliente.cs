using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M01S09.Aula02.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Name")]
        [StringLength(150)]
        [Required]
        public string Nome { get; set; }

        [Column("Endereco_Id")]
        [Required]
        public int EnderecoId { get; set; }

        //propriedades virtuais
        [ForeignKey("EnderecoId")]
        public virtual Endereco EnderecoDeEntrega { get; set; }

        //muitas compras
        public virtual ICollection<Compra> Compras { get; set; }
    }
}
