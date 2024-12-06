namespace PublishingHouse.Abstractions.Entity
{
    public interface IQualityMark
    {
        public int QualityMarkId { get; set; }
        public string? Name { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
