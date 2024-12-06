namespace PublishingHouse.Abstractions.Entity
{
    public interface IPrintOrder
    {
        public int OrderId { get; set; }
        public int Number { get; set; }
        public string PrintType { get; set; }
        public string PaperType { get; set; }
        public string CoverType { get; set; }
        public string FasteningType { get; set; }
        public bool IsLaminated { get; set; }
        public double Price { get; set; }
        public int OrderStatusId { get; set; }
        public DateOnly? RegistrationDate { get; set; }
        public DateOnly? CompletionDate { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public ICollection<IBatchPrint> BatchPrints { get; set; }
        public ICustomer Customer { get; set; }
        public IEmployee Employee { get; set; }
        public IOrderStatus OrderStatus { get; set; }
    }
}
