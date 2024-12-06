namespace PublishingHouse.Abstractions.Entity
{
    public interface IPosition
    {
        public int PositionId { get; set; }
        public string? Name { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
