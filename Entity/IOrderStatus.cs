namespace PublishingHouse.Abstractions.Entity
{
    public interface IOrderStatus
    {
        public int OrderStatusId { get; set; }
        public string? Name { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public ICollection<IPrintOrder> PrintOrders { get; set; }

    }
}
