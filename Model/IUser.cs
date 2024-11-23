namespace PublishingHouse.Abstractions.Model;

public interface IUser
{
    int UserId { get; set; }
    int RoleId { get; set; }
    string Username { get; set; }
    string PasswordHash { get; set; }
    string FullName { get; set; }
    string Email { get; set; }
    string? PhoneNumber { get; set; }
    DateTime? CreateDateTime { get; set; }
    DateTime? UpdateDateTime { get; set; }
}