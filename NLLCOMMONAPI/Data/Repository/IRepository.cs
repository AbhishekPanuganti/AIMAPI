using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLLCOMMONAPI.Data.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<T>> QueryAsync<T>(string procedure, object parameters = null);
        Task<T> QuerySingleAsync<T>(string procedure, object parameters = null);
        Task<int> ExecuteAsync(string procedure, object parameters = null);
    }
}
