using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_Entities;
using MongoDB.Driver;

namespace Domain_Interfaces
{
    public interface IOperatieRepository
    {
        Task<IEnumerable<Operatie>> GetAll();
        Task<Operatie> Get(string id);
        Task Add(Operatie item);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(string id, Operatie operatie);
    }
}