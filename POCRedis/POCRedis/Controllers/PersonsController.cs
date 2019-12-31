using BeetleX.Redis;
using Microsoft.AspNetCore.Mvc;
using POCRedis.Contexts;
using POCRedis.Domain.Entities;
using System.Linq;

namespace POCRedis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostPerson([FromBody] Person person)
        {
            Redis.Publish(typeof(Person).FullName, person);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            using var context = new MyContext();
            return Ok(context.Persons.ToList());
        }
    }
}