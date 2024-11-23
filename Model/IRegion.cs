namespace PublishingHouse.Abstractions.Model;

public interface IRegion
{
    int RegionId { get; set; }
    string? Name { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
