namespace PublishingHouse.Abstractions.Entity
{
    public interface IRegion
    {
        public int RegionId { get; set; }
        public string? Name { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
