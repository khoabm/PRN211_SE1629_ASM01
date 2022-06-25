using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StockDataProvider
    {
        public StockDataProvider()
        {

        }
        private string ConnectionString { get; set; }
        public StockDataProvider(string connectionString) => ConnectionString = connectionString;
        public void CloseConnection(SqlConnection connection) => connection.Close();

        public SqlParameter CreateParameter(string name, int size, object value, DbType dbtype, ParameterDirection parameterDirection = ParameterDirection.Input)
        {
            return new SqlParameter
            {
                DbType = dbtype,
                ParameterName = name,
                Size = size,
                Value = value,
                Direction = parameterDirection
            };
        }

        public IDataReader GetDataReader(string commandText, CommandType commandType, out SqlConnection sqlConnection, params SqlParameter[] parameters)
        {
            IDataReader? reader = null;
            try
            {
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                var command = new SqlCommand(commandText, sqlConnection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var p in parameters)
                    {
                        command.Parameters.Add(p);
                    }
                }
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return reader;
        }

        public void Delete(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var p in parameters)
                    {
                        command.Parameters.Add(p);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void Insert(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var p in parameters)
                    {
                        command.Parameters.Add(p);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void Update(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var p in parameters)
                    {
                        command.Parameters.Add(p);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
