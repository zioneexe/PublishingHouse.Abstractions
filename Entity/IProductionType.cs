namespace PublishingHouse.Abstractions.Entity
{
    public interface IProductionType
    {
        public int ProductionTypeId { get; set; }
        public string? Name { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
