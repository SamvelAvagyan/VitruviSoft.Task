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
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository groupRepository;

        public GroupController(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }

        // GET: api/<GroupController>
        [HttpGet]
        public IEnumerable<Group> Get()
        {
            return groupRepository.GetAll();
        }

        // GET api/<GroupController>/5
        [HttpGet("{id}")]
        public Group Get(int id)
        {
            return groupRepository.GetById(id);
        }

        // POST api/<GroupController>
        [HttpPost]
        public void Post([FromBody] Group group)
        {
            groupRepository.Add(group);
        }

        // PUT api/<GroupController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Group group)
        {
            groupRepository.Update(group);
        }

        // DELETE api/<GroupController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            groupRepository.Delete(id);
        }
    }
}
