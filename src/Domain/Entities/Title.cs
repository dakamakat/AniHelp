namespace Domain.Entities
{
    public class Title
    {
        public string En { get; set; }
        public string En_jp { get; set; }
        public string Ja_jp { get; set; }
        public string En_us { get; set; }
        public int AttributesId { get; set; }
        public Attribute Attributes { get; set; }
    }
}
