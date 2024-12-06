namespace PublishingHouse.Abstractions.Entity
{
    public interface ICity
    {
        public int CityId { get; set; }
        public int RegionId { get; set; }
        public string? Name { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public ICollection<IProduction> Productions { get; set; }
        public IRegion Region { get; set; }
    }
}
