using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_Entities;
using MongoDB.Driver;

namespace Domain_Interfaces
{
    public interface ITaraRepository
    {
        Task<IEnumerable<Tara>> GetAll();
        Task<Tara> Get(string id);
        Task Add(Tara item);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(string id, Tara tara);
    }
}