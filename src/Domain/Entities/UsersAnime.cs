using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UsersAnime
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
    }
}
