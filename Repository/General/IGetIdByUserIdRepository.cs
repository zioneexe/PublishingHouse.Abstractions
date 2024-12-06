namespace PublishingHouse.Abstractions.Repository.General
{
    public interface IGetIdByUserIdRepository<T>
    {
        Task<int> GetIdByUserIdAsync(string userId);
    }
}