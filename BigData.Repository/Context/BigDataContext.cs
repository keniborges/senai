using BigData.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BigData.Repository.Context
{
    public class BigDataContext : DbContext
    {
        public BigDataContext(DbContextOptions<BigDataContext> options) : base(options) { }

        #region DbSets

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Telefone> Telefones { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
