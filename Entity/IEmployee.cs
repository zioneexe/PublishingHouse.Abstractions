namespace PublishingHouse.Abstractions.Entity
{
    public interface IEmployee
    {
        public int EmployeeId { get; set; }
        public string? UserId { get; set; }
        public int PositionId { get; set; }
        public int ProductionId { get; set; }
        public string? Name { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public IPosition Position { get; set; }
        public ICollection<IPrintOrder> PrintOrders { get; set; }
        public IProduction Production { get; set; }
    }
}
