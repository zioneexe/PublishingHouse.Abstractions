namespace PublishingHouse.Abstractions.Model;

public interface IProduction
{
    int ProductionId { get; set; }
    int ProductionTypeId { get; set; }
    int CityId { get; set; }
    string? Address { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
