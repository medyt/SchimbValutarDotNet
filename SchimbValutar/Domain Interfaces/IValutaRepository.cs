using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_Entities;
using MongoDB.Driver;

namespace Domain_Interfaces
{
    public interface IValutaRepository
    {
        Task<IEnumerable<Valuta>> GetAll();
        Task<Valuta> Get(string id);
        Task Add(Valuta item);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(string id, Valuta valuta);
    }
}