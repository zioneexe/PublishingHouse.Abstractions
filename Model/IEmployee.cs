namespace PublishingHouse.Abstractions.Model;

public interface IEmployee
{
    int EmployeeId { get; set; }
    int UserId { get; set; }
    int PositionId { get; set; }
    int ProductionId { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
