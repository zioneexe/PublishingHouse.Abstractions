namespace PublishingHouse.Abstractions.Model;

public interface ICustomerType
{
    int CustomerTypeId { get; set; }
    string? Name { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
