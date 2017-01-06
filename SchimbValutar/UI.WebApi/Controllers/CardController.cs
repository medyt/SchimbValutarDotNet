using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_Entities;
using Domain_Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CardController : Controller
    {
        private readonly ICardRepository _cardRepository;
        public CardController(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        // GET: api/Card
        [HttpGet]
        public Task<IEnumerable<Card>> Get()
        {
            return GetCardInternal();
        }

        private async Task<IEnumerable<Card>> GetCardInternal()
        {
            return await _cardRepository.GetAll();
        }

        // GET api/Card/5
        [HttpGet("{id}")]
        public Task<Card> Get(string id)
        {
            return GetCardByIdInternal(id);
        }

        private async Task<Card> GetCardByIdInternal(string id)
        {
            return await _cardRepository.Get(id);
        }

        // POST api/Card
        [HttpPost]
        public void Post([FromBody]Card card)
        {
            _cardRepository.Add(card);
        }

        // PUT api/Card/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Card card)
        {
            _cardRepository.Update(id, card);
        }

        // DELETE api/Card/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _cardRepository.Remove(id);
        }
    }
}
