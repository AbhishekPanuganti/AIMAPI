using System.Threading.Tasks;
using NLLCOMMONAPI.Data.Interfaces;
using NLLCOMMONAPI.Data.Models.User;
using NLLCOMMONAPI.Data.Repository;

namespace NLLCOMMONAPI.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository _repository;

        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserLoginResult> CheckQRLoginAsync(string username, string password)
        {
            var result = await _repository.QuerySingleAsync<UserLoginResult>(
                "checkQRLogin", new { username, password });

            return result ?? new UserLoginResult { token = null };
        }
    }
}
