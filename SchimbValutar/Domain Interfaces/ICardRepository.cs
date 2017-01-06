using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_Entities;
using MongoDB.Driver;

namespace Domain_Interfaces
{
    public interface ICardRepository
    {
        Task<IEnumerable<Card>> GetAll();
        Task<Card> Get(string id);
        Task Add(Card item);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(string id, Card card);
    }
}