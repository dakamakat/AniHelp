using System;
using Domain.Entities;
using Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Images)
                 .HasKey(img => img.Id);

            builder.Property(img => img.Type)
                .IsRequired();

            builder.HasMany(img => img.Sizes)
                .WithOne(img => img.Image)
                .HasForeignKey(img => img.ImageId);
        }
    }
}
