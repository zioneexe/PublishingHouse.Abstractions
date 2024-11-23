namespace PublishingHouse.Abstractions.Model;

public interface IBatchPrint
{
    int BatchPrintId { get; set; }
    string Number { get; set; }
    int BookQuantity { get; set; }
    int OrderId { get; set; }
    DateOnly? PrintDate { get; set; }
    int QualityMarkId { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
