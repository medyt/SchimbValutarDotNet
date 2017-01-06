using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_Entities;
using MongoDB.Driver;

namespace Domain_Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAll();
        Task<Client> Get(string id);
        Task Add(Client item);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(string id, Client client);
    }
}
