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
    public class CasierController : Controller
    {
        private readonly ICasierRepository _casierRepository;
        public CasierController(ICasierRepository casierRepository)
        {
            _casierRepository = casierRepository;
        }

        // GET: api/Casier
        [HttpGet]
        public Task<IEnumerable<Casier>> Get()
        {
            return GetCasierInternal();
        }

        private async Task<IEnumerable<Casier>> GetCasierInternal()
        {
            return await _casierRepository.GetAll();
        }

        // GET api/Casier/5
        [HttpGet("{id}")]
        public Task<Casier> Get(string id)
        {
            return GetCasierByIdInternal(id);
        }

        private async Task<Casier> GetCasierByIdInternal(string id)
        {
            return await _casierRepository.Get(id);
        }

        // POST api/Casier
        [HttpPost]
        public void Post([FromBody]Casier casier)
        {
            _casierRepository.Add(casier);
        }

        // PUT api/Casier/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Casier casier)
        {
            _casierRepository.Update(id, casier);
        }

        // DELETE api/Casier/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _casierRepository.Remove(id);
        }
    }
}
