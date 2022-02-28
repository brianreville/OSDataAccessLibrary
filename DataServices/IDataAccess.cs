namespace OSDataAccessLibrary
{
    public interface IDataAccess
    {
        Task<bool> AddAsync<T>(string sql, T parameters);
        Task<bool> AddAsyncString<T>(string sql, T parameters);
        Task<T> GetIndvAsync<T, U>(string sql, U parameters);
        Task<List<T>> GetList<T, U>(string sql, U parameters);
        Task<bool> UpdateAsync<T>(string sql, T parameters);
        Task<bool> UpdateListAsync<T>(string sql, T parameters);
    }
}