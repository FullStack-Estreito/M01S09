using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M01S09.Aula02.Models
{
    [Table("Produto")]
    public class Produto
    {

        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Name")]
        [StringLength(100)]
        [Required]
        public string Nome { get; set; }

        [Column("Categoria")]
        [StringLength(50)]
        [Required]
        public string Categoria { get; set; }

        [Column("PrecoUnitario", TypeName="decimal(9,2)")]
        [Required]
        public double PrecoUnitario { get; set; }

        //muitas compras
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<PromocaoProduto> Promocoes { get; set; }
    }
}
