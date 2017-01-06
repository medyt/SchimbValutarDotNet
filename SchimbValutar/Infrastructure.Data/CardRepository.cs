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
    public class CardRepository : ICardRepository
    {
        private readonly CardContext _context;

        public CardRepository(IOptions<Settings> settings)
        {
            _context = new CardContext(settings);
        }

        public async Task<IEnumerable<Card>> GetAll()
        {
            return await _context.Carduri.Find(_ => true).ToListAsync();
        }

        public async Task<Card> Get(string id)
        {
            var filter = Builders<Card>.Filter.Eq("Id", id);

            return await _context.Carduri
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task Add(Card item)
        {
            await _context.Carduri.InsertOneAsync(item);
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _context.Carduri.DeleteOneAsync(
                Builders<Card>.Filter.Eq("Id", id));
        }

        public async Task<UpdateResult> Update(string id, Card card)
        {
            var filter = Builders<Card>.Filter.Eq(s => s.Id, id);
            var update = Builders<Card>.Update
                .Set(s => s.Id, card.Id);
                //TODO update each field

            return await _context.Carduri.UpdateOneAsync(filter, update);
        }
    }
}
