using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OSDataAccessLibrary.DataServices
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "Default";

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);
            var data = await connection.QueryAsync<T>(sql, parameters, commandType: CommandType.StoredProcedure);

            return data.ToList();
        }

        public async Task<T> GetSingleData<T, U>(string sql, U parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);
            var data = await connection.QueryAsync<T>(sql, parameters, commandType: CommandType.StoredProcedure);

            var result = data.FirstOrDefault();
            // handle null at data level
            return result;
        }

        public async Task<int> SaveDataQueryString<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);
            var res = await connection.ExecuteAsync(sql, parameters);
            return res;

        }

        public async Task<int> SaveData<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);
            var res = await connection.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);
            return res;
        }

        public async Task<int> DeleteData<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);
            var res = await connection.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);
            return res;
        }
        // returns a string value
        public async Task<string> SqlStringData<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);
            var res = connection.QuerySingle(sql, parameters);
            if (res is null)
            {
                return "";
            }
            else
            {
                return res;
            }
        }

        // for the purpose of non stored procedure calls
        public async Task<int> SqlStringDataInt<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);
            var res = connection.ExecuteScalar<int>(sql, parameters);
            return res;
        }

        public async Task<List<T>> GetAnnoymousList<T, U>(string sql, U parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);
            var data = await connection.QueryAsync<T>(sql, parameters);

            return data.ToList();
        }

    }
}

