using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class BaseDAL
    {
        public StockDataProvider StockDataProvider { get; set; } = null;
        public SqlConnection connection = null;

        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            StockDataProvider = new StockDataProvider(connectionString);
        }
        public string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true).Build();
            connectionString = config["ConnectionString:MemberManagement"];
            return connectionString;
        }
        public void CloseConnection() => StockDataProvider.CloseConnection(connection);
    }
}
