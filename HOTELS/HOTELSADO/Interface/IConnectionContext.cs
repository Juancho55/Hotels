
using System.Data.SqlClient;
using System.Data;

namespace HOTELSADO.Interface
{
    public interface IConnectionContext
    {
        Task<int> ExecuteNonQueryAsync(string procedure, params SqlParameter[] parameters);
        Task<DataSet> Fill(string procedure, params SqlParameter[] parameters);
        Task<DataSet> Views(string viewName);
    }
}
