using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace M01S09.Aula02.Models
{
    public class Compra
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Quantidade")]
        [Required]
        public int Quantidade { get; set; }

        [Column("Preco", TypeName = "decimal(9,2)")]
        [Required]
        public double Preco { get; set; }

        [Column("Cliente_Id")]
        public int ClienteId { get; set; }

        [Column("Produto_Id")]
        [Required]
        public int ProdutoId { get; set; }

        
        //propriedades virtuais para indicação de relacionamento

        [ForeignKey("ClienteId")]
        public virtual Cliente ClienteCompra { get; set; }

        [ForeignKey("ProdutoId")]
        public virtual Produto ProdutoCompra { get; set; }
    }
}
