using OSDataAccessLibrary.Model;

namespace OSDataAccessLibrary.DataServices
{
    public interface ILoginData
    {
        Task<bool> RegisteredDevice(string address, int userid);
        Task<List<Login>> VerifyLogin(string username, string password);
    }
}