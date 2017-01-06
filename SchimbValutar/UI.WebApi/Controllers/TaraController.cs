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
    public class TaraController : Controller
    {
        private readonly ITaraRepository _taraRepository;
        public TaraController(ITaraRepository taraRepository)
        {
            _taraRepository = taraRepository;
        }

        // GET: api/Tara
        [HttpGet]
        public Task<IEnumerable<Tara>> Get()
        {
            return GetTaraInternal();
        }

        private async Task<IEnumerable<Tara>> GetTaraInternal()
        {
            return await _taraRepository.GetAll();
        }

        // GET api/Tara/5
        [HttpGet("{id}")]
        public Task<Tara> Get(string id)
        {
            return GetTaraByIdInternal(id);
        }

        private async Task<Tara> GetTaraByIdInternal(string id)
        {
            return await _taraRepository.Get(id);
        }

        // POST api/Tara
        [HttpPost]
        public void Post([FromBody]Tara tara)
        {
            _taraRepository.Add(tara);
        }

        // PUT api/Tara/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Tara tara)
        {
            _taraRepository.Update(id, tara);
        }

        // DELETE api/Tara/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _taraRepository.Remove(id);
        }
    }
}
