using BigData.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BigData.Repository.Configurators
{
    public abstract class BaseEntityConfigurator<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id).IsRequired();

            InternalConfigure(builder);
        }

        protected abstract void InternalConfigure(EntityTypeBuilder<TEntity> builder);
    }
}
