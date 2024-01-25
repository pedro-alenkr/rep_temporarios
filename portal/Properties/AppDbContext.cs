using Microsoft.EntityFrameworkCore;

namespace portal.Properties
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Models.UsuarioModel> UserDAO {get; set;}
        public DbSet<Models.LivroModel> LivroDAO {get; set;}
    }
}