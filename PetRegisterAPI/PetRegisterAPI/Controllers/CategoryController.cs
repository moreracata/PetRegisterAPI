using AutoMapper;
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
        private readonly IRepository _repository;
        private readonly ILogger<OwnerController> _logger;
        private readonly IMapper _mapper;

        public CategoryController(IRepository rep,
            ILogger<OwnerController> logger,
            IMapper mapper)
        {
            _repository = rep;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<List<CategoryDTO>> GetCategory()
        {
            var caterories = await _repository.GetCategoryList();
            var cateroriesDTO = _mapper.Map<List<CategoryDTO>>(caterories);
            return cateroriesDTO;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDTO>> Get(int id)
        {

            var category = await _repository.GetCategoryData(id);
            var categoryDTO = _mapper.Map<CategoryDTO>(category);

            if (category == null)
            {
                return NotFound();
            }

            return categoryDTO;
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
