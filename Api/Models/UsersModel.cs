using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("Users")]
    public class UsersModel
    {
        [Column("Id")]
        public long Id { get; set; }

        [Column("Name")]
        public string Name { get; set; } = string.Empty;

        [Column("Password")]
        public string Password { get; set; } = string.Empty;

        [Column("Email")]
        public string Email { get; set; } = string.Empty;

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Column("UserType")]
        public int UserType { get; set; }
    }
}