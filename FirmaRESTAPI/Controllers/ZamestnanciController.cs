using Microsoft.AspNetCore.Mvc;
using FirmaRESTAPI.Models;

namespace FirmaRESTAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ZamestnanciController : ControllerBase {
        // GET: api/<ZamestnanciController>

        [HttpGet]
        public IQueryable<Zamestnanci> GetEmployees() {
            var context = new firmaContext();
            return context.Zamestnanci;
        }

        // GET api/<ZamestnanciController>/5
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id) {
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
        public IActionResult PostEmployee(ZamestnanciNode employee) {
            var context = new firmaContext();
            if (employee.isValid()) {
                var newEmployee = employee.SimpleToZamestnanec();
                try {
                    context.Zamestnanci.Add(newEmployee);
                    context.SaveChanges();
                    return Ok(newEmployee);

                }
                catch {
                    return BadRequest();
                }
            }
            return BadRequest("Some of the required data is missing!");


        }

        // PUT api/<ZamestnanciController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, ZamestnanciNode employeeChanges) {
            var context = new firmaContext();
            var employee = context.Zamestnanci.SingleOrDefault(x => x.Id == id);

            if (employee != null) {
                if (!employeeChanges.isValid()) {
                    return BadRequest("Some of the data is missing!");
                }
                employee.Titul = employeeChanges.Titul;
                employee.Meno = employeeChanges.Meno;
                employee.Priezvisko = employeeChanges.Priezvisko;
                employee.Telefon = employeeChanges.Telefon;
                employee.Email = employeeChanges.Email;
                context.SaveChanges();
                return Ok(employee);
            }
            else {
                return NotFound();
            }

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
