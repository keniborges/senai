using IntegraApi.Entidades;
using Microsoft.EntityFrameworkCore;

namespace IntegraApi.Context
{
    public class IntegraContext : DbContext
    {
        public IntegraContext(DbContextOptions<IntegraContext> options) : base(options) { }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=SenaiColegio;User Id=postgres;Password=admin;");
        }
    }
}
