using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("users")]
    public class UsersModel
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("nome")]
        public string Name { get; set; } = string.Empty;

        [Column("senha")]
        public string Password { get; set; } = string.Empty;

        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Column("telefone")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Column("usertype")]
        public int UserType { get; set; }
    }
}