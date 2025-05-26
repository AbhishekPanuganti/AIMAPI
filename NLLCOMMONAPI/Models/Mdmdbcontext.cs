using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Remoting;

namespace NLLCOMMONAPI.Models
{

    public class Mdmdbcontext : DbContext
    {
        public Mdmdbcontext(DbContextOptions<Mdmdbcontext> options) : base(options)
        {
        }
        public DbSet<getSettings_Result> settings { get; set; }
        public DbSet<ExceptionlogModel> ExceptionlogModel { get; set; }
        public DbSet<SystemlogModel> SystemlogModel { get; set; }

        // Example method for stored procedure execution
        public async Task<List<getSettings_Result>> GetSettingsAsync()
        {
          
            return await this.Set<getSettings_Result>()
                .FromSqlRaw("EXEC getSettings")
                .ToListAsync();
            //var categoryIdParam = new SqlParameter("@CategoryId", categoryId);
            //return await this.Set<ProductDto>()
            //    .FromSqlRaw("EXEC GetProductsByCategory @CategoryId", categoryIdParam)
            //    .ToListAsync();
        }

        public async Task<int> SaveSystemLog(SystemlogModel obj)
        {
            var resultId = this.Database.ExecuteSqlRawAsync("EXEC insertsysteminfo @userid = {0},@module = {1},@activity = {2}", obj.userid, obj.module, obj.activity);
            return await resultId;

        }

        public async Task<int> SaveExceptionLog(ExceptionlogModel obj)
        {
            var resultId = this.Database.ExecuteSqlRawAsync("EXEC insert_applicationException @userid = {0},@username = {1},@apipath = {2},@exeptiontext = {3}", obj.userid, obj.username, obj.apipath,obj.exeptiontext);
            return await resultId;

        }


    }
}
