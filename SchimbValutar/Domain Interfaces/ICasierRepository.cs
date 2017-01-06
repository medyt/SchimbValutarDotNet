using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_Entities;
using MongoDB.Driver;

namespace Domain_Interfaces
{
    public interface ICasierRepository
    {
        Task<IEnumerable<Casier>> GetAll();
        Task<Casier> Get(string id);
        Task Add(Casier item);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(string id, Casier casier);
    }
}