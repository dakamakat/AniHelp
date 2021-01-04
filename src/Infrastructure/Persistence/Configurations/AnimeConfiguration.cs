using System;
using Domain.Entities;
using Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Attribute = Domain.Entities.Attribute;

namespace Infrastructure.Persistence.Configurations
{

    /// <summary>
    /// EF configuration for Profile entity
    /// </summary>
    public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Anime> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Animes)
             .HasKey(anime => anime.Id);

            builder.Property(anime => anime.Type)
                 .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(anime => anime.SelfLink)
                 .IsRequired()
                 .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.HasOne(anime => anime.Attributes)
                .WithOne(attribute => attribute.Anime)
                .HasForeignKey<Attribute>(attribute => attribute.AnimeId)
                .OnDelete(DeleteBehavior.Restrict);              

            builder.HasMany(anime => anime.Links)
               .WithOne(relationship => relationship.Anime)
               .HasForeignKey(relationship => relationship.AnimeId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
