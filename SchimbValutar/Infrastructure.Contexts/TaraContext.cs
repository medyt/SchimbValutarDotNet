using DatabaseSettings;
using Domain_Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.Contexts
{
    public class TaraContext
    {
        private readonly IMongoDatabase _database;

        public TaraContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Tara> Tari => _database.GetCollection<Tara>("Tari");
    }
}