using System;
using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Identity;
using Infrastructure.Persistence.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Attribute = Domain.Entities.Attribute;

namespace Infrastructure.Persistence
{
    /// <summary>
    /// Application context
    /// </summary>
    public class AniHelpDbContext : IdentityDbContext<ApplicationUser> , IAniHelpDbContext
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options"></param>
        public AniHelpDbContext(DbContextOptions<AniHelpDbContext> options)
            : base(options) { }


        // Entities.
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<RatingFrequencie> RatingFrequencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.ApplyConfiguration(new AnimeConfiguration());
            modelBuilder.ApplyConfiguration(new AttributesConfiguration());
            modelBuilder.ApplyConfiguration(new RatingFrequenciesConfiguration());
            modelBuilder.ApplyConfiguration(new SizeConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new LinkConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
