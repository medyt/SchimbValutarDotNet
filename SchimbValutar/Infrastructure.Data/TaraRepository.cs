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
    public class TaraRepository : ITaraRepository
    {
        private readonly TaraContext _context;

        public TaraRepository(IOptions<Settings> settings)
        {
            _context = new TaraContext(settings);
        }

        public async Task<IEnumerable<Tara>> GetAll()
        {
            return await _context.Tari.Find(_ => true).ToListAsync();
        }

        public async Task<Tara> Get(string id)
        {
            var filter = Builders<Tara>.Filter.Eq("Id", id);

            return await _context.Tari
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task Add(Tara item)
        {
            await _context.Tari.InsertOneAsync(item);
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _context.Tari.DeleteOneAsync(
                Builders<Tara>.Filter.Eq("Id", id));
        }

        public async Task<UpdateResult> Update(string id, Tara tara)
        {
            var filter = Builders<Tara>.Filter.Eq(s => s.Id, id);
            var update = Builders<Tara>.Update
                .Set(s => s.Id, tara.Id);
            //TODO update each field

            return await _context.Tari.UpdateOneAsync(filter, update);
        }
    }
}
