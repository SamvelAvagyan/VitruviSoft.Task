using BusinessLogic;
using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderRepository providerRepository;

        public ProviderController(IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;
        }

        // GET: api/<ProviderController>
        [HttpGet]
        public IEnumerable<Provider> Get()
        {
            return providerRepository.GetAll();
        }

        // GET api/<ProviderController>/5
        [HttpGet("{id}")]
        public Provider Get(int id)
        {
            return providerRepository.GetById(id);
        }

        // POST api/<ProviderController>
        [HttpPost]
        public void Post([FromBody] Provider provider)
        {
            providerRepository.Add(provider);
        }

        // PUT api/<ProviderController>/5
        [HttpPut]
        public void Put([FromBody] Provider provider)
        {
            providerRepository.Update(provider);
        }

        // DELETE api/<ProviderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            providerRepository.Delete(id);
        }
    }
}
