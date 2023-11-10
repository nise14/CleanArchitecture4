using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Contoso.Repository.Dapper;

public class Connection
{
    public SqlConnection SqlConnection { get; } = null!;

    public Connection(IConfiguration config)
    {
        SqlConnection = new SqlConnection(config["Connection"]);
    }
}
