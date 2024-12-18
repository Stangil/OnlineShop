using Dapper;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ShopBackendLibrary.Models;
using System.Reflection.Metadata;

namespace ShopBackendLibrary.SqlDataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadData<T>(string storedProc, string connectionName, object? parameters)
        {
            try
            {
                string connectionString = _config.GetConnectionString(connectionName)
                    ?? throw new Exception($"Missing connection string at {connectionName}");
                using var connection = new SqlConnection(connectionString);
                var rows = await connection.QueryAsync<T>(
                    storedProc,
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure
                    );
                return rows.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public async Task<List<T>> LoadCategoryItems<T>(string storedProc, string connectionName, int parameter)
        {
            try
            {
                string connectionString = _config.GetConnectionString(connectionName)
                    ?? throw new Exception($"Missing connection string at {connectionName}");
                using var connection = new SqlConnection(connectionString);
                var dic = new Dictionary<string, object> { { "@CategoryID", parameter } };
                var parameters = new DynamicParameters(dic);
                var rows = await connection.QueryAsync<T>(
                    storedProc,
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure
                    );
                return rows.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public async Task SaveData(string storedProc, string connectionName, object parameters)
        {
            try
            {
                string connectionString = _config.GetConnectionString(connectionName)
                    ?? throw new Exception($"Missing connection string at {connectionName}");
                using var connection = new SqlConnection(connectionString);
                await connection.ExecuteAsync(
                    storedProc,
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save Data Exception: " + ex.Message);
            }
        }
    }
}
