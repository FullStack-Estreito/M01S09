using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M01S09.Aula02.Models
{
    [Table("Promocao_Produto")]
    public class PromocaoProduto
    {
        [Column("Id")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("Produto_Id")]
        [Required]
        public int ProdutoId { get; set; }

        [Column("Promocao_Id")]
        [Required]
        public int PromocaoId { get; set; }

        //propriedades virtuais
        [ForeignKey("ProdutoId")]
        public virtual Produto Produto { get; set; }

        [ForeignKey("PromocaoId")]
        public virtual Promocao Promocao { get; set; }

    }
}
