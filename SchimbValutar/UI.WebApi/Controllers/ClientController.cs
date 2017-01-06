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
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        // GET: api/client
        [HttpGet]
        public Task<IEnumerable<Client>> Get()
        {
            return GetClientInternal();
        }

        private async Task<IEnumerable<Client>> GetClientInternal()
        {
            return await _clientRepository.GetAll();
        }

        // GET api/client/5
        [HttpGet("{id}")]
        public Task<Client> Get(string id)
        {
            return GetClientByIdInternal(id);
        }

        private async Task<Client> GetClientByIdInternal(string id)
        {
            return await _clientRepository.Get(id);
        }

        // POST api/client
        [HttpPost]
        public void Post([FromBody]Client client)
        {
            _clientRepository.Add(client);
        }

        // PUT api/client/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Client client)
        {
            _clientRepository.Update(id, client);
        }

        // DELETE api/client/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _clientRepository.Remove(id);
        }
    }
}
