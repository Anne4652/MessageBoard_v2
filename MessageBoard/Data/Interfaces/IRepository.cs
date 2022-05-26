namespace MessageBoard.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> ListItemsAsync();
        Task<T> GetItemAsync(int id);
        Task CreateAsync(T item);
        void Delete(T item);
        Task DeleteByIdAsync(int id);
        void Update(T model);
        Task SaveAsync();
    }
}
