using System;
using Domain.Entities;
using Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class AttributesConfiguration : IEntityTypeConfiguration<Domain.Entities.Attribute>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Attribute> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Attributes)
             .HasKey(attributes => attributes.Id);

            builder.Property(attributes => attributes.CreatedAt)
                .HasColumnType(ConfigurationContants.SqlDateFormat)
                .IsRequired();

            builder.Property(attributes => attributes.UpdatedAt)
            .HasColumnType(ConfigurationContants.SqlDateFormat);

            builder.Property(attributes => attributes.StartDate)
           .HasColumnType(ConfigurationContants.SqlDateFormat);

            builder.Property(attributes => attributes.EndDate)
           .HasColumnType(ConfigurationContants.SqlDateFormat);


            builder.Property(arr => arr.AbbreviatedTitles)
                 .HasConversion(v => string.Join(',', v), v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

            builder.HasOne(attributes => attributes.RatingFrequencies)
                .WithOne(rat => rat.Attributes)
                .HasForeignKey<RatingFrequencie>(rat => rat.AttributesId);


            builder.HasMany(attributes => attributes.Images)
              .WithOne(img => img.Attributes)
              .HasForeignKey(img => img.AttributesId);

            builder.OwnsOne(attributes => attributes.Titles)
              .WithOwner(tit => tit.Attributes)
              .HasForeignKey(tit => tit.AttributesId);
        }

    }
}
