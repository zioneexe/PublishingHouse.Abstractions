namespace PublishingHouse.Abstractions.Entity
{
    public interface ICustomer
    {
        public int CustomerId { get; set; }
        public int CustomerTypeId { get; set; }
        public string Name { get; set; }
        public DateOnly? AddressDate { get; set; }
        public string? UserId { get; set; }
        public string? Email { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public ICustomerType CustomerType { get; set; }
        public ICollection<IPrintOrder> PrintOrders { get; set; }
        public ICollection<IOrderRequest> OrderRequests { get; set; }
    }
}
