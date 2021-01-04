using Domain.Enums;

namespace Domain.Entities
{
    public class Link
    {
        public int Id { get; set; }
        public LinkType Type { get; set; }
        public string Self {get; set; }
        public string Related { get; set; }
        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
    }
}
