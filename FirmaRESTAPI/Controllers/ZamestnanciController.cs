using Microsoft.AspNetCore.Mvc;
using FirmaRESTAPI.Models;

namespace FirmaRESTAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ZamestnanciController : ControllerBase {
        // GET: api/<ZamestnanciController>

        [HttpGet]
        public IQueryable<Zamestnanci> Get() {
            var context = new firmaContext();
            return context.Zamestnanci;
        }

        // GET api/<ZamestnanciController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var context = new firmaContext();
            var employee = context.Zamestnanci.SingleOrDefault(x => x.Id == id);
            if (employee != null) {
                return Ok(employee);
            }
            else {
                return NotFound();
            }
        }

        // POST api/<ZamestnanciController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<ZamestnanciController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<ZamestnanciController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var context = new firmaContext();
            var employeeToRemove = context.Zamestnanci.SingleOrDefault(x => x.Id == id);
            if (employeeToRemove != null) {
                context.Zamestnanci.Remove(employeeToRemove);
                context.SaveChanges();
                return Ok(employeeToRemove);
            }
            else {
                return NotFound();
            }
        }
    }
}
