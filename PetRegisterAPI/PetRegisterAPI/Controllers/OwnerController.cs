using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetRegisterAPI.Models;
using PetRegisterAPI.ModelsDTO;
using PetRegisterAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetRegisterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly ILogger<OwnerController> _logger;
        private readonly IMapper _mapper;

        public OwnerController(IRepository rep,
                               ILogger<OwnerController> logger,
                               IMapper mapper)
        {
            _repository = rep;
            _logger = logger;
            _mapper = mapper;
        }
     

        // GET: api/<OwnerController>
        [HttpGet]
        public async Task<List<OwnerDTO>> Get()
        {
            var owners = await _repository.GetOwnerList();
            var ownersDTO = _mapper.Map<List<OwnerDTO>>(owners);
            return ownersDTO;
        }


        // GET api/<OwnerController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<OwnerDTO>> Get(int id)
        {
            var owner = await _repository.GetOwnerData(id);
            var ownertDTO = _mapper.Map<OwnerDTO>(owner);

            if (owner == null)
            {
                return NotFound();
            }

            return ownertDTO;

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
