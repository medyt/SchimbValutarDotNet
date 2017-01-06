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
    public class OperatieRepository : IOperatieRepository
    {
        private readonly OperatieContext _context;

        public OperatieRepository(IOptions<Settings> settings)
        {
            _context = new OperatieContext(settings);
        }

        public async Task<IEnumerable<Operatie>> GetAll()
        {
            return await _context.Operatii.Find(_ => true).ToListAsync();
        }

        public async Task<Operatie> Get(string id)
        {
            var filter = Builders<Operatie>.Filter.Eq("Id", id);

            return await _context.Operatii
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task Add(Operatie item)
        {
            await _context.Operatii.InsertOneAsync(item);
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _context.Operatii.DeleteOneAsync(
                Builders<Operatie>.Filter.Eq("Id", id));
        }

        public async Task<UpdateResult> Update(string id, Operatie Operatie)
        {
            var filter = Builders<Operatie>.Filter.Eq(s => s.Id, id);
            var update = Builders<Operatie>.Update
                .Set(s => s.Id, Operatie.Id);
            //TODO update each field

            return await _context.Operatii.UpdateOneAsync(filter, update);
        }
    }
}
