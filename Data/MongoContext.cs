using HomeManager.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace HomeManager.Data;

public class MongoContext
{
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<Product> _collection;
    private readonly IMongoCollection<Movie> _collectionMovies;
    private readonly IMongoCollection<Menu> _collectionMenus;

    public MongoContext(IOptions<MongoDbSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString);
        _database = client.GetDatabase(settings.Value.DatabaseName);
        _collection = _database.GetCollection<Product>(settings.Value.CollectionName);
        _collectionMovies = _database.GetCollection<Movie>(settings.Value.CollectionName);
        _collectionMenus = _database.GetCollection<Menu>(settings.Value.CollectionName);
    }

    public IMongoCollection<Product> Products => _collection;
    public IMongoCollection<Movie> Movies => _collectionMovies;
    public IMongoCollection<Menu> Menus => _collectionMenus;
}
