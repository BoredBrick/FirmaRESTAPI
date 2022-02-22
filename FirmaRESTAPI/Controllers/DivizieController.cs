using Microsoft.AspNetCore.Mvc;
using FirmaRESTAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirmaRESTAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DivizieController : ControllerBase {
        // GET: api/<DivizieController>
        [HttpGet]
        public IQueryable<Divizie> Get() {
            var context = new firmaContext();
            return context.Divizie;
        }

        // GET api/<DivizieController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var context = new firmaContext();
            var division = context.Divizie.SingleOrDefault(x => x.Id == id);
            if (division is null) {
                return NotFound();
            }
            else {
                return Ok(division);
            }
        }

        // POST api/<DivizieController>
        [HttpPost]
        public IActionResult Post(BaseNode division) {
            if (!division.isValid()) {
                return BadRequest("Some of the required data is incorrect or missing!");
            }

            var context = new firmaContext();
            var newDivision = division.baseToDivizie();
            try {
                context.Divizie.Add(newDivision);
                context.SaveChanges();
                return Ok(newDivision);
            }
            catch {
                return BadRequest();
            }
        }

        // PUT api/<DivizieController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, BaseNode divisionChanges) {
            if (!divisionChanges.isValid()) {
                return BadRequest("Some of the required data is incorrect or missing!");
            }

            var context = new firmaContext();
            var division = context.Divizie.SingleOrDefault(x => x.Id == id);
            if (division is null) {
                return NotFound();
            }

            try {
                divisionChanges = divisionChanges.baseToDivizie();
                division.Nazov = divisionChanges.Nazov;
                division.IdVeduci = divisionChanges.IdVeduci;
                division.IdPatriPod = divisionChanges.IdPatriPod;
                context.SaveChanges();
                return Ok(division);
            }
            catch {
                return BadRequest();
            }
        }

        // DELETE api/<DivizieController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var context = new firmaContext();
            var divisionToRemove = context.Divizie.SingleOrDefault(x => x.Id == id);
            if (divisionToRemove is null) {
                return NotFound();
            }

            context.Divizie.Remove(divisionToRemove);
            context.SaveChanges();
            return Ok(divisionToRemove);
        }
    }
}
