using System.Threading.Tasks;
using POSApp.API.Models;


namespace POSApp.API.Data
{
    public interface IAuthRepository
    {
         Task<user> Register (user user, string password);
         Task<user> Login (string username,string password);
         Task<bool> UserExist(string username);
    }
}