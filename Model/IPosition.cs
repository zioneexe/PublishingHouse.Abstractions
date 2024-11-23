namespace PublishingHouse.Abstractions.Model;

public interface IPosition
{
    int PositionId { get; set; }
    string? Name { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
