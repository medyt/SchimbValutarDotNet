using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseSettings;
using Domain_Entities;
using Domain_Interfaces;
using Infrastructure.Contexts;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Infrastructure.Data
{
    public class CursRepository : ICursRepository
    {
        private readonly CursContext _context;

        public CursRepository(IOptions<Settings> settings)
        {
            _context = new CursContext(settings);
        }

        public async Task<IEnumerable<Curs>> GetAll()
        {
            return await _context.Cursuri.Find(_ => true).ToListAsync();
        }

        public async Task<Curs> Get(string id)
        {
            var filter = Builders<Curs>.Filter.Eq("Id", id);

            return await _context.Cursuri
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task Add(Curs item)
        {
            await _context.Cursuri.InsertOneAsync(item);
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _context.Cursuri.DeleteOneAsync(
                Builders<Curs>.Filter.Eq("Id", id));
        }

        public async Task<UpdateResult> Update(string id, Curs curs)
        {
            var filter = Builders<Curs>.Filter.Eq(s => s.Id, id);
            var update = Builders<Curs>.Update
                .Set(s => s.Id, curs.Id);
            //TODO update each field

            return await _context.Cursuri.UpdateOneAsync(filter, update);
        }
    }
}
