using OSDataAccessLibrary.DataServices;

namespace OSDataAccessLibrary
{
    public class DataAccess : IDataAccess
    {
        private readonly ISqlDataAccess _db;

        public DataAccess(ISqlDataAccess db)
        {
            _db = db;
        }

        // adds a single object
        public async Task<bool> AddAsync<T>(string sql, T parameters)
        {
            var res = await _db.SaveData(sql, parameters);
            return res > 0;
        }
        // updates a single object
        public async Task<bool> UpdateAsync<T>(string sql, T parameters)
        {
            var res = await _db.SaveData(sql, parameters);
            return res > 0;
        }
        // updates a list of objects through a udt
        public async Task<bool> UpdateListAsync<T>(string sql, T parameters)
        {
            var res = await _db.SaveData(sql, parameters);
            return res > 0;
        }
        // returns a single object
        public async Task<T> GetIndvAsync<T, U>(string sql, U parameters)
        {
            var res = await _db.GetSingleData<T, U>(sql, parameters);
            return res;
        }
        // gets a list of objects with params and stored procedure type to be sent in request
        public async Task<List<T>> GetList<T, U>(string sql, U parameters)
        {
            var res = await _db.LoadData<T, U>(sql, parameters);
            return res;
        }

        public async Task<bool> AddAsyncString<T>(string sql, T parameters)
        {
            var res = await _db.SaveDataQueryString<T>(sql, parameters);
            return res > 0;
        }
    }
}
