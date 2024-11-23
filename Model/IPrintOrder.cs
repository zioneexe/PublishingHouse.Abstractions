namespace PublishingHouse.Abstractions.Model;

public interface IPrintOrder
{
    int OrderId { get; set; }
    int Number { get; set; }
    string PrintType { get; set; }
    string PaperType { get; set; }
    string CoverType { get; set; }
    string FasteningType { get; set; }
    bool IsLaminated { get; set; }
    double Price { get; set; }
    int OrderStatusId { get; set; }
    DateOnly? RegistrationDate { get; set; }
    DateOnly? CompletionDate { get; set; }
    int CustomerId { get; set; }
    int EmployeeId { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
