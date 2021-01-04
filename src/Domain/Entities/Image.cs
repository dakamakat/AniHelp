using System.Collections.Generic;
using Domain.Enums;

namespace Domain.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public ImageType Type { get; set; }
        public string Tiny { get; set; }
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Large { get; set; }
        public string Original { get; set; }
        public ICollection<Size> Sizes { get; set; }
        public int AttributesId { get; set; }
        public Attribute Attributes { get; set; }
    }
}
