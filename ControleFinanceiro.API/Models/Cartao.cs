using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiro.API.Models
{
    [Table("cartao")]
    public class Cartao
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("descricao")]
        public string? Descricao { get; set; }
        [Column("ativo")]
        public bool? Ativo { get; set; }
    }
}