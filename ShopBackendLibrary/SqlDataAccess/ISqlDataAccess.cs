using ShopBackendLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBackendLibrary.SqlDataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadCategoryItems<T>(string storedProc, string connectionName, int parameter);
        Task<List<T>> LoadData<T>(string storedProc, string connectionName, object parameters);
        Task SaveData(string storedProc, string connectionName, object parameters);
    }
}
