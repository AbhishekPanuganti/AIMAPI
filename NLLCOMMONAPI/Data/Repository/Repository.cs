using Dapper;
using NLLCOMMONAPI.Data.Repository;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace NLLCOMMONAPI.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly DapperContext _context;

        public Repository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string procedure, object parameters = null)
        {
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<T>(procedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<T> QuerySingleAsync<T>(string procedure, object parameters = null)
        {
            using var connection = _context.CreateConnection();
            return await connection.QuerySingleOrDefaultAsync<T>(procedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<int> ExecuteAsync(string procedure, object parameters = null)
        {
            using var connection = _context.CreateConnection();
            return await connection.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
