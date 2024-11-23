namespace PublishingHouse.Abstractions.Model;

public interface IOrderStatus
{
    int OrderStatusId { get; set; }
    string? Name { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
