namespace PublishingHouse.Abstractions.Model;

public interface ICustomer
{
    int CustomerId { get; set; }
    int CustomerTypeId { get; set; }
    string Name { get; set; }
    DateOnly? AddressDate { get; set; }
    string? Email { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
