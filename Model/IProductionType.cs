namespace PublishingHouse.Abstractions.Model;

public interface IProductionType
{
    int ProductionTypeId { get; set; }
    string? Name { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
