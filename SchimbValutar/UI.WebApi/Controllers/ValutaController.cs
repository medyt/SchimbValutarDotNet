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
    public class ValutaController : Controller
    {
        private readonly IValutaRepository _valutaRepository;
        public ValutaController(IValutaRepository valutaRepository)
        {
            _valutaRepository = valutaRepository;
        }

        // GET: api/Valuta
        [HttpGet]
        public Task<IEnumerable<Valuta>> Get()
        {
            return GetValutaInternal();
        }

        private async Task<IEnumerable<Valuta>> GetValutaInternal()
        {
            return await _valutaRepository.GetAll();
        }

        // GET api/Valuta/5
        [HttpGet("{id}")]
        public Task<Valuta> Get(string id)
        {
            return GetValutaByIdInternal(id);
        }

        private async Task<Valuta> GetValutaByIdInternal(string id)
        {
            return await _valutaRepository.Get(id);
        }

        // POST api/Valuta
        [HttpPost]
        public void Post([FromBody]Valuta valuta)
        {
            _valutaRepository.Add(valuta);
        }

        // PUT api/Valuta/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Valuta valuta)
        {
            _valutaRepository.Update(id, valuta);
        }

        // DELETE api/Valuta/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _valutaRepository.Remove(id);
        }
    }
}
