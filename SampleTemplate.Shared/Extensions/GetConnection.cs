using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SampleTemplate.Shared.Extensions
{
    public class GetConnection
    {
        public static IConfiguration _configuration;
        public GetConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public static SqlConnection GetConnectionString()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = _configuration.GetConnectionString("SampleTemplateDb");

            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }
    }
}
