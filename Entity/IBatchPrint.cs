namespace PublishingHouse.Abstractions.Entity
{
    public interface IBatchPrint
    {
        public int BatchPrintId { get; set; }
        public string Number { get; set; }
        public int BookQuantity { get; set; }
        public int OrderId { get; set; }
        public DateOnly? PrintDate { get; set; }
        public int QualityMarkId { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public IPrintOrder Order { get; set; }
        public IQualityMark QualityMark { get; set; }
    }
}
