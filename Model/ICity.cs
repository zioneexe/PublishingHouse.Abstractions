namespace PublishingHouse.Abstractions.Model;

public interface ICity
{
    int CityId { get; set; }
    int RegionId { get; set; }
    string? Name { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
