using DatabaseSettings;
using Domain_Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.Contexts
{
    public class ValutaContext
    {
        private readonly IMongoDatabase _database;

        public ValutaContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Valuta> Valute => _database.GetCollection<Valuta>("Valute");
    }
}