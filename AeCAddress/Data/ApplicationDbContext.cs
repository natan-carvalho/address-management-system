using Microsoft.EntityFrameworkCore;

namespace AeCAddress.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Usuarios { get; set; }
        public DbSet<AddressModel> Endereco { get; set; }
    }
}