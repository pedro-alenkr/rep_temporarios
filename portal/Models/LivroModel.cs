using System.ComponentModel.DataAnnotations.Schema;

namespace portal.Models;

[Table("Livro")]
public class LivroModel
{   
    public long? Id { get; set; }

    public string Nome { get; set; }

    public string Estilo { get; set; }

    public int Pontos { get; set; }

    public string Sinopse { get; set; }

    public string Texto { get; set; }

    public int Paginas { get; set; }
}
