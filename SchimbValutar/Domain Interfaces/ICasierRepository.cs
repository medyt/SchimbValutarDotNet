using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_Entities;
using MongoDB.Driver;
using System;

namespace Domain_Interfaces
{
    public interface ICasierRepository
    {
        Task<IEnumerable<Casier>> GetAll();
        Task<Casier> Get(Guid id);
        Task Add(Casier item);
        Task<DeleteResult> Remove(Guid id);
        Task<UpdateResult> Update(Guid id, Casier casier);
    }
}