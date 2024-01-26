namespace GraphQLHotChocolate.Interfaces
{
    public interface IRepository
    {
        IQueryable<T> GetAll<T>();
        Task<T> Add<T>();
        Task<T> Update<T>();
        Task<T> Delete<T>();
    }
}
