using Microsoft.AspNetCore.Mvc;
using PetRegisterAPI.Models;
using PetRegisterAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetRegisterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository repository;

        public CategoryController(IRepository rep)
        {
            repository = rep;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<List<Category>> GetCategory()
        {
            var result = await repository.GetCategoryList();
            return result;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            var category = await repository.GetCategoryData(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
