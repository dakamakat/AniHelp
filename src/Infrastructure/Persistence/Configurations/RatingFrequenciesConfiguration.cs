using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Infrastructure.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class RatingFrequenciesConfiguration : IEntityTypeConfiguration<RatingFrequencie>
    {
        public void Configure(EntityTypeBuilder<RatingFrequencie> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.RatingFrequencies)
                 .HasKey(rat => rat.Id);
        }
    }
}
