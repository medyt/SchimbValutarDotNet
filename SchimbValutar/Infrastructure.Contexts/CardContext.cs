using DatabaseSettings;
using Domain_Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.Contexts
{
    public class CardContext
    {
        private readonly IMongoDatabase _database;

        public CardContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Card> Carduri => _database.GetCollection<Card>("Carduri");
    }
}