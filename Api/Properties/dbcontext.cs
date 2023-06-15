using Microsoft.EntityFrameworkCore;

namespace Api.Properties
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> options) : base(options){}

        public DbSet<Models.UsersModel> Users { get; set; }
    }
}