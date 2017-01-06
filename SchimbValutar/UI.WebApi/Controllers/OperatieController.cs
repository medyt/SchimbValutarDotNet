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
    public class OperatieController : Controller
    {
        private readonly IOperatieRepository _operatieRepository;
        public OperatieController(IOperatieRepository operatieRepository)
        {
            _operatieRepository = operatieRepository;
        }

        // GET: api/Operatie
        [HttpGet]
        public Task<IEnumerable<Operatie>> Get()
        {
            return GetOperatieInternal();
        }

        private async Task<IEnumerable<Operatie>> GetOperatieInternal()
        {
            return await _operatieRepository.GetAll();
        }

        // GET api/Operatie/5
        [HttpGet("{id}")]
        public Task<Operatie> Get(string id)
        {
            return GetOperatieByIdInternal(id);
        }

        private async Task<Operatie> GetOperatieByIdInternal(string id)
        {
            return await _operatieRepository.Get(id);
        }

        // POST api/Operatie
        [HttpPost]
        public void Post([FromBody]Operatie operatie)
        {
            _operatieRepository.Add(operatie);
        }

        // PUT api/Operatie/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Operatie operatie)
        {
            _operatieRepository.Update(id, operatie);
        }

        // DELETE api/Operatie/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _operatieRepository.Remove(id);
        }
    }
}
