namespace PublishingHouse.Abstractions.Model;

public interface IAdmin
{
    int AdminId { get; set; }
    int UserId { get; set; }
    string? Department { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}