
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
     [Table("products")]
    public class ProductsModel
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("nome")]
        public string Name { get; set; } = string.Empty;

        [Column("valor")]
        public decimal Value { get; set; }

        [Column("quantidade")]
        public int Amount { get; set; }

        [Column("descricao")]
        public string Description { get; set; } = string.Empty;
    }
}