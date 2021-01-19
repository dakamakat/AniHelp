using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Anime
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string SelfLink { get; set; }
        public Attribute Attributes { get; set; }
        public ICollection<Link> Links { get; set; }
        public ICollection<AppUser> Users { get; set; }
        public ICollection<UsersAnime> UsersAnimes { get; set; }
    }
}
