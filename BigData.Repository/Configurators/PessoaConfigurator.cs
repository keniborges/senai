using BigData.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BigData.Repository.Configurators
{
    public class PessoaConfigurator : BaseEntityConfigurator<Pessoa>
    {
        protected override void InternalConfigure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.Property(c => c.Id);
            builder.Property(c => c.Nome).HasMaxLength(60).IsRequired(true);
            builder.Property(c => c.Sexo).IsRequired(true);
            builder.ToTable(nameof(Pessoa));
        }
    }
}
