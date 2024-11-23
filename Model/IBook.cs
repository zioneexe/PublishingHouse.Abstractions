namespace PublishingHouse.Abstractions.Model;

public interface IBook
{
    int BookId { get; set; }
    string Name { get; set; }
    int AuthorId { get; set; }
    int GenreId { get; set; }
    int? Sku { get; set; }
    string? Isbn { get; set; }
    int? Pages { get; set; }
    int? PublicationYear { get; set; }
    string? Size { get; set; }
    double? Weight { get; set; }
    string? Annotation { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
