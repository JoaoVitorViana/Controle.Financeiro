using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiro.API.Models
{
    [Table("despesa")]
    public class Despesa
    {
        [Key]
        [Column("id")]
        public Int64 Id { get; set; }
        [Column("dataHora")]
        public DateTime? Data { get; set; }
        [Column("recorrente")]
        public bool? Recorrente { get; set; }
        [Column("valor")]
        public decimal? Valor { get; set; }
        [Column("parcela")]
        public int? Parcela { get; set; }
        [Column("totalParcela")]
        public int? TotalParcela { get; set; }
        [Column("mes")]
        public int Mes { get; set; }
        [Column("ano")]
        public int Ano { get; set; }
        
        [ForeignKey("Cartao")]
        [Column("idCartao")]
        public int? IdCartao { get; set; }
        public virtual Cartao Cartao { get; set; }
    }
}