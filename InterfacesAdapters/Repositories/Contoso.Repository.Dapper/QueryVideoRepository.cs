using Contoso.Entities;
using Contoso.Entities.Abstractions.Repositories.Queries;
using Dapper;

namespace Contoso.Repository.Dapper;

public class QueryVideoRepository : IQueryVideoRepository
{
    private readonly Connection _connection;

    public QueryVideoRepository(Connection connection)
    {
        _connection = connection;
    }

    public async Task<List<Video>> GetAllVideosByTitle(string title)
    {
        var dictionary = new Dictionary<string, string>()
        {
            {"@Title",title}
        };

        var query = "SELECT * FROM Videos where Title=@Title";
        var response = await _connection.SqlConnection.QueryAsync<Video>(query, dictionary);
        return response.ToList();
    }
}