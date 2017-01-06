using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_Entities;
using MongoDB.Driver;

namespace Domain_Interfaces
{
    public interface ICursRepository
    {
        Task<IEnumerable<Curs>> GetAll();
        Task<Curs> Get(string id);
        Task Add(Curs item);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(string id, Curs curs);
    }
}