using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        public ICollection<Anime> Animes { get; set; }
        public ICollection<UsersAnime> UsersAnime { get; set; }
    }
}
