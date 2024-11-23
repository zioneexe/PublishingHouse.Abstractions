namespace PublishingHouse.Abstractions.Model;

public interface IOrderBook
{
    int OrderBooksId { get; set; }
    int OrderId { get; set; }
    int BookId { get; set; }
    int BookQuantity { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
