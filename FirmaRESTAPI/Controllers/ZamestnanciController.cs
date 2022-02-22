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
            if (employee is null) {
                return NotFound();
            }
            else {
                var baseEmployee = new ZamestnanciNode(employee);
                return Ok(baseEmployee);

            }
        }

        // POST api/<ZamestnanciController>
        [HttpPost]
        public IActionResult PostEmployee(ZamestnanciNode baseEmployee) {
            if (!baseEmployee.isValid()) {
                return BadRequest("Some of the required data is incorrect or missing!");
            }

            var context = new firmaContext();
            var newEmployee = new Zamestnanci(baseEmployee);
            try {
                context.Zamestnanci.Add(newEmployee);
                context.SaveChanges();
                return Ok(newEmployee);
            }
            catch {
                return BadRequest();
            }
        }

        // PUT api/<ZamestnanciController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, ZamestnanciNode employeeChanges) {
            if (!employeeChanges.isValid()) {
                return BadRequest("Some of the required data is incorrect or missing!");
            }

            var context = new firmaContext();
            var employee = context.Zamestnanci.SingleOrDefault(x => x.Id == id);
            if (employee is null) {
                return NotFound();
            }

            employee.Titul = employeeChanges.Titul;
            employee.Meno = employeeChanges.Meno;
            employee.Priezvisko = employeeChanges.Priezvisko;
            employee.Telefon = employeeChanges.Telefon;
            employee.Email = employeeChanges.Email;
            context.SaveChanges();
            return Ok(employee);

        }

        // DELETE api/<ZamestnanciController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var context = new firmaContext();
            var employeeToRemove = context.Zamestnanci.SingleOrDefault(x => x.Id == id);
            if (employeeToRemove is null) {
                return NotFound();
            }
            context.Zamestnanci.Remove(employeeToRemove);
            context.SaveChanges();
            return Ok(employeeToRemove);
        }
    }
}
