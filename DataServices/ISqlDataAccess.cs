namespace OSDataAccessLibrary.DataServices
{
    public interface ISqlDataAccess
    {
        Task<int> DeleteData<T>(string sql, T parameters);
        Task<List<T>> GetAnnoymousList<T, U>(string sql, U parameters);
        Task<T> GetSingleData<T, U>(string sql, U parameters);
        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task<int> SaveData<T>(string sql, T parameters);
        Task<int> SaveDataQueryString<T>(string sql, T parameters);
        Task<string> SqlStringData<T>(string sql, T parameters);
        Task<int> SqlStringDataInt<T>(string sql, T parameters);
    }
}