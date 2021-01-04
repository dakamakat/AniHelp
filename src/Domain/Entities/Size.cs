using Domain.Enums;

namespace Domain.Entities
{
    public class Size
    {
        public int Id { get; set; }
        public SizeType Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
