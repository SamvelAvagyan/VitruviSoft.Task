using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Repository.Infrastructure.Configurations
{
    class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.ToTable("Providers");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Type).HasColumnName("Type").HasMaxLength(50).IsRequired();
            builder.Property(x => x.GroupId).HasColumnName("GroupId").IsRequired();
            builder.Property(x => x.Active).HasColumnName("Active").IsRequired();
            builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn").IsRequired();
            builder.Property(x => x.ModifiedOn).HasColumnName("ModifiedOn").IsRequired();
        }
    }
}
