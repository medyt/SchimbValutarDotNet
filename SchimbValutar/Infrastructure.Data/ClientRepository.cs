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
    public class ClientRepository: IClientRepository
    {
        private readonly ClientContext _context;

        public ClientRepository(IOptions<Settings> settings)
        {
            _context = new ClientContext(settings);
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            return await _context.Clients.Find(_ => true).ToListAsync();
        }

        public async Task<Client> Get(string id)
        {
            var filter = Builders<Client>.Filter.Eq("Id", id);

            return await _context.Clients
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task Add(Client item)
        {
            await _context.Clients.InsertOneAsync(item);
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _context.Clients.DeleteOneAsync(
                Builders<Client>.Filter.Eq("Id", id));
        }

        public async Task<UpdateResult> Update(string id, Client client)
        {
            var filter = Builders<Client>.Filter.Eq(s => s.Id, id);
            var update = Builders<Client>.Update
                .Set(s => s.Nume, client.Nume)
                .Set(s => s.Prenume, client.Prenume)
                .Set(s => s.DenumireTara, client.DenumireTara)
                .Set(s => s.CodTara, client.CodTara)
                .Set(s => s.TipDocumentIdentitate, client.TipDocumentIdentitate)
                .Set(s => s.SerieDocumentIdentitate, client.SerieDocumentIdentitate)
                .Set(s => s.NumarDocumentIdentitate, client.NumarDocumentIdentitate)
                .Set(s => s.IsNigger, client.IsNigger)
                .Set(s => s.IsOwner, client.IsOwner)
                .Set(s => s.IsAdmin, client.IsAdmin);
            return await _context.Clients.UpdateOneAsync(filter, update);
        }
    }
}
