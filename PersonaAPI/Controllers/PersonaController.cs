using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonaAPI.Services.PersonService;

namespace PersonaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonaController(IPersonService personService)
        {
            _personService = personService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAllPersons()
        {
            return await _personService.GetAllPersons();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetSinglePerson(int id)
        {
            var result = await _personService.GetSinglePerson(id);
            if (result == null)
                return NotFound(" Person not found ");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Person>>> AddPerson(Person per)
        {
            var result = await _personService.AddPerson(per);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Person>>> UpdatePerson(int id, Person request)
        {
            var result = await _personService.UpdatePerson(id, request);
            if (result == null)
                return NotFound(" Person not found ");
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Person>>> DeletePerson(int id)
        {
            var result = await _personService.DeletePerson(id);
            if (result == null)
                return NotFound(" Person not found ");
            return Ok(result);
        }
    }
}
