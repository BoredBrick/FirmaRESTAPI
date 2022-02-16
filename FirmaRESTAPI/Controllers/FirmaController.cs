using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirmaRESTAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase {
        // GET: api/<FirmaController>
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FirmaController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<FirmaController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<FirmaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<FirmaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
