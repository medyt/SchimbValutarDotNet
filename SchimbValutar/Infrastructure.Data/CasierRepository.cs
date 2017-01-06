using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseSettings;
using Domain_Entities;
using Domain_Interfaces;
using Infrastructure.Contexts;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.Data
{
    public class CasierRepository : ICasierRepository
    {
        private readonly CasierContext _context;

        public CasierRepository(IOptions<Settings> settings)
        {
            _context = new CasierContext(settings);
        }

        public async Task<IEnumerable<Casier>> GetAll()
        {
            return await _context.Casieri.Find(_ => true).ToListAsync();
        }

        public async Task<Casier> Get(string id)
        {
            var filter = Builders<Casier>.Filter.Eq("Id", id);

            return await _context.Casieri
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task Add(Casier item)
        {
            await _context.Casieri.InsertOneAsync(item);
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _context.Casieri.DeleteOneAsync(
                Builders<Casier>.Filter.Eq("Id", id));
        }

        public async Task<UpdateResult> Update(string id, Casier casier)
        {
            var filter = Builders<Casier>.Filter.Eq(s => s.Id, id);
            var update = Builders<Casier>.Update
                .Set(s => s.Nume, casier.Nume)
                .Set(s => s.Prenume, casier.Prenume);
                //TODO update each field
            return await _context.Casieri.UpdateOneAsync(filter, update);
        }
    }
}
