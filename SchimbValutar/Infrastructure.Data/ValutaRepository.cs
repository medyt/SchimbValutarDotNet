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
    public class ValutaRepository : IValutaRepository
    {
        private readonly ValutaContext _context;

        public ValutaRepository(IOptions<Settings> settings)
        {
            _context = new ValutaContext(settings);
        }

        public async Task<IEnumerable<Valuta>> GetAll()
        {
            return await _context.Valute.Find(_ => true).ToListAsync();
        }

        public async Task<Valuta> Get(string id)
        {
            var filter = Builders<Valuta>.Filter.Eq("Id", id);

            return await _context.Valute
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task Add(Valuta item)
        {
            await _context.Valute.InsertOneAsync(item);
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _context.Valute.DeleteOneAsync(
                Builders<Valuta>.Filter.Eq("Id", id));
        }

        public async Task<UpdateResult> Update(string id, Valuta Valuta)
        {
            var filter = Builders<Valuta>.Filter.Eq(s => s.Id, id);
            var update = Builders<Valuta>.Update
                .Set(s => s.Id, Valuta.Id);
            //TODO update each field

            return await _context.Valute.UpdateOneAsync(filter, update);
        }
    }
}
