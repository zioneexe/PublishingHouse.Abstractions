namespace PublishingHouse.Abstractions.Entity
{
    public interface IProduction
    {
        public int ProductionId { get; set; }
        public int ProductionTypeId { get; set; }
        public int CityId { get; set; }
        public string? Address { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public ICity City { get; set; }
        public ICollection<IEmployee> Employees { get; set; }
        public IProductionType ProductionType { get; set; }
    }
}
