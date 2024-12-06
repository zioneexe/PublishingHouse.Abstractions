namespace PublishingHouse.Abstractions.Entity
{
    public interface IOrderBook
    {
        public int OrderBooksId { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int BookQuantity { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public IBook Book { get; set; }
        public IPrintOrder Order { get; set; }
    }
}
