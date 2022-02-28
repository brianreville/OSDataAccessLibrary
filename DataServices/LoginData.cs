using Dapper;
using OSDataAccessLibrary.Model;

namespace OSDataAccessLibrary.DataServices
{

    public class LoginData : ILoginData
    {
        private readonly ISqlDataAccess _db;

        public LoginData(ISqlDataAccess db)
        {
            _db = db;
        }
        // verifies the users login details
        public async Task<List<Login>> VerifyLogin(string username, string password)
        {
            DynamicParameters p = new();
            p.Add("@username", username);
            p.Add("@password", password);

            string sql = "dbo.spLoginVerify";

            var user = await _db.LoadData<Login, dynamic>(sql, p);

            return user;
        }

        // checks whether device is registered or not
        public async Task<bool> RegisteredDevice(string address, int userid)
        {
            DynamicParameters p = new();
            p.Add("@address", address);
            p.Add("@userid", userid);

            string sql = "dbo.spDeviceRegistered";

            var res = await _db.SaveData<dynamic>(sql, p);
            return res > 0;
        }

    }
}
