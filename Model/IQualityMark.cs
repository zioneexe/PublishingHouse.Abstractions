namespace PublishingHouse.Abstractions.Model;

public interface IQualityMark
{
    int QualityMarkId { get; set; }
    string? Name { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
