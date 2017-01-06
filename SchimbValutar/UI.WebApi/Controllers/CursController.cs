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
    public class CursController : Controller
    {
        private readonly ICursRepository _cursRepository;
        public CursController(ICursRepository cursRepository)
        {
            _cursRepository = cursRepository;
        }

        // GET: api/Curs
        [HttpGet]
        public Task<IEnumerable<Curs>> Get()
        {
            return GetCursInternal();
        }

        private async Task<IEnumerable<Curs>> GetCursInternal()
        {
            return await _cursRepository.GetAll();
        }

        // GET api/Curs/5
        [HttpGet("{id}")]
        public Task<Curs> Get(string id)
        {
            return GetCursByIdInternal(id);
        }

        private async Task<Curs> GetCursByIdInternal(string id)
        {
            return await _cursRepository.Get(id);
        }

        // POST api/Curs
        [HttpPost]
        public void Post([FromBody]Curs curs)
        {
            _cursRepository.Add(curs);
        }

        // PUT api/Curs/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Curs curs)
        {
            _cursRepository.Update(id, curs);
        }

        // DELETE api/Curs/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _cursRepository.Remove(id);
        }
    }
}
