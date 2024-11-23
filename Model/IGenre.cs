namespace PublishingHouse.Abstractions.Model;

public interface IGenre
{
    int GenreId { get; set; }
    string? Name { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}
