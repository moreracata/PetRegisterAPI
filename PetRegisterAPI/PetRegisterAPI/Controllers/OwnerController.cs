using Microsoft.AspNetCore.Mvc;
using PetRegisterAPI.Models;
using PetRegisterAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetRegisterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IRepository repository;
        public OwnerController(IRepository rep)
        {
            repository = rep;
        }

        // GET: api/<OwnerController>
        [HttpGet]
        public async Task<List<Owner>> Get()
        {
            var result = await repository.GetOwnerList();
            return result;
        }


        // GET api/<OwnerController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Owner>> Get(int id)
        {
            var owner = await repository.GetOwnerData(id);

            if (owner == null)
            {
                return NotFound();
            }

            return owner;
        }

        // POST api/<OwnerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
