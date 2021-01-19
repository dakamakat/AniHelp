using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Attribute = Domain.Entities.Attribute;

namespace Application.Common.Interfaces
{
    public interface IAniHelpDbContext
    {
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<RatingFrequencie> RatingFrequencies { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
    }
}
