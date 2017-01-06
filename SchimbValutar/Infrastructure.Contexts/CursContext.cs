using DatabaseSettings;
using Domain_Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.Contexts
{
    public class CursContext
    {
        private readonly IMongoDatabase _database;

        public CursContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Curs> Cursuri => _database.GetCollection<Curs>("Cursuri");
    }
}