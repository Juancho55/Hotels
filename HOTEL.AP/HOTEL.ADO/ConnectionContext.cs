
using HOTEL.API.ADO.Interface;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HOTEL.API.ADO
{
    public class ConnectionContext : IConnectionContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _database;

        public ConnectionContext(IConfiguration configuration, string database)
        {
            _configuration = configuration;
            _database = database;
        }

        private SqlConnection GetSqlCnn()
        {
            return new SqlConnection(_configuration.GetConnectionString(_database));
        }

        public async Task<int> ExecuteNonQueryAsync(string procedure, params SqlParameter[] parameters)
        {
            try
            {
                using var sqlCnn = GetSqlCnn();
                using var sqlCmd = new SqlCommand(procedure, sqlCnn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter param in parameters)
                {
                    sqlCmd.Parameters.Add(param);
                }
                sqlCnn.Open();
                return await sqlCmd.ExecuteNonQueryAsync();
            }
            catch (SqlException e)
            {
                string message = $"Message: {e.Message}, Number: {e.Number}, Procedure: {e.Procedure}, LineNumber: {e.LineNumber}";
                throw new Exception(message, e);
            }
        }

        public Task<DataSet> Fill(string procedure, params SqlParameter[] parameters)
        {
            try
            {
                return Task.Run(() =>
                {
                    DataSet mDataSet = new DataSet();
                    using var sqlCnn = GetSqlCnn();
                    using var sqlCmd = new SqlCommand(procedure, sqlCnn);
                    using var sqlAdapter = new SqlDataAdapter(sqlCmd);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        foreach (SqlParameter param in parameters)
                        {
                            sqlCmd.Parameters.Add(param);
                        }
                    }
                    sqlAdapter.SelectCommand.CommandTimeout = 15000;
                    sqlAdapter.Fill(mDataSet);
                    return mDataSet;
                });
            }
            catch (SqlException e)
            {
                string message = $"Message: {e.Message}, Number: {e.Number}, Procedure: {e.Procedure}, LineNumber: {e.LineNumber}";
                throw new Exception(message, e);
            }
        }

        public Task<DataSet> Views(string viewName)
        {
            try
            {
                return Task.Run(() =>
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    using var sqlCnn = GetSqlCnn();
                    using var sqlCmd = new SqlCommand($"SELECT * FROM {viewName}", sqlCnn);
                    adapter.SelectCommand = sqlCmd;
                    adapter.SelectCommand.CommandTimeout = 15000;
                    adapter.Fill(ds, "Users");
                    return ds;
                });
            }
            catch (SqlException e)
            {
                string message = $"Message: {e.Message}, Number: {e.Number}, Procedure: {e.Procedure}, LineNumber: {e.LineNumber}";
                throw new Exception(message, e);
            }
        }
    }
}
