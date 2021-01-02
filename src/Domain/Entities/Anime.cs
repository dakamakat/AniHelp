using System;

namespace Domain.Entities
{
    public class Anime
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public Link Links { get; set; }
        public Attributes Attributes { get; set; }
        public Relationships Relationships { get; set; }
    }
}
