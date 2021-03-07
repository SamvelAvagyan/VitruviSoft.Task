using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Repository.Infrastructure.Configurations
{
    class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Groups");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Type).HasColumnName("Type").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Active).HasColumnName("Active").IsRequired();
            builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn").IsRequired();
            builder.Property(x => x.ModifiedOn).HasColumnName("ModifedOn").IsRequired();

            builder.Metadata.FindNavigation(nameof(Group.Providers)).SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasMany(x => x.Providers).WithOne(b => b.Group).HasForeignKey(b => b.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
