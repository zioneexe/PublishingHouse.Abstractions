namespace PublishingHouse.Abstractions.Model;

public interface IAuthor
{
    int AuthorId { get; set; }
    string? Name { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
