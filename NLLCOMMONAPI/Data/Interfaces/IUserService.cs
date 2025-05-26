using System.Threading.Tasks;
using NLLCOMMONAPI.Data.Models.User;

namespace NLLCOMMONAPI.Data.Interfaces
{
    public interface IUserService
    {
        Task<UserLoginResult> CheckQRLoginAsync(string username, string password);
    }
}
