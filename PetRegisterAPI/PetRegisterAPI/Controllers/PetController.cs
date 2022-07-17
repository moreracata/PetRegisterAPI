using Microsoft.AspNetCore.Mvc;
using PetRegisterAPI.Repositories;
using PetRegisterAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetRegisterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IRepository repository;

        public PetController(IRepository rep)
        {
            repository = rep;
        }

        // GET: api/<PetController>
        [HttpGet]
        public async Task<List<Pet>> Get()
        {
            var result = await repository.GetPetList();
            return result;
        }

        // GET api/<PetController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> Get(int id)
        {
            var pet = await repository.GetPetData(id);

            if (pet == null)
            {
                return NotFound();
            }

            return pet;
        }

        // POST api/<PetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
