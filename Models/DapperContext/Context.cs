using System.Data;
using System.Data.SqlClient;

namespace EczaneApi.Models.DapperContext
{
    public class Context
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectingString;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectingString = _configuration.GetConnectionString("connection");  //appsettingsjson da oluşturduğumuz configuration dosyasındaki bağlantıyı alıyoruz
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectingString);
    }
}
