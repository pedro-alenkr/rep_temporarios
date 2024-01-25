using System.ComponentModel.DataAnnotations.Schema;

namespace portal.Models;

[Table("Usuario")]
public class UsuarioModel
{
    public long? Id { get; set; }

    public string Nome { get; set; }

    public string Livros { get; set; }

    public int Pontos { get; set; }

    public string Conquistas { get; set; }
}
