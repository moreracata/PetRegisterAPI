using Microsoft.AspNetCore.Mvc;
using PetRegisterAPI.Repositories;
using PetRegisterAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using PetRegisterAPI.ModelsDTO;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetRegisterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly ILogger<PetController> _logger;
        private readonly IMapper _mapper;


        public PetController(ILogger<PetController> logger,
                             IRepository rep,
                             IMapper mapper)
        {
            _repository = rep;
            _logger = logger;
            _mapper = mapper;   
        }

        // GET: api/<PetController>
        [HttpGet]
        //[ResponseCache(Duration=60)]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PetDTO>> Get()
        {
            var pets = await _repository.GetPetList();
            var petsDTO = _mapper.Map<List<PetDTO>>(pets);
            return petsDTO;
        }

        // GET api/<PetController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PetDTO>> Get(int id)
        {
            var pet = await _repository.GetPetData(id);

            var petDTO = _mapper.Map<PetDTO>(pet);
            
            if (pet == null)
            {
                return NotFound();
            }

            return petDTO;
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
