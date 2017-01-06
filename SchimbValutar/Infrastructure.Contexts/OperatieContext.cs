using DatabaseSettings;
using Domain_Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.Contexts
{
    public class OperatieContext
    {
        private readonly IMongoDatabase _database;

        public OperatieContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Operatie> Operatii => _database.GetCollection<Operatie>("Operatii");
    }
}