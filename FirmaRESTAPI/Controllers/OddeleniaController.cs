using Microsoft.AspNetCore.Mvc;
using FirmaRESTAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirmaRESTAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class OddeleniaController : ControllerBase {

        [HttpGet]
        public IQueryable<Oddelenia> Get() {
            var context = new firmaContext();
            return context.Oddelenia;
        }

        // GET api/<ProjektyController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var context = new firmaContext();
            var department = context.Oddelenia.SingleOrDefault(x => x.Id == id);
            if (department != null) {
                return Ok(department);
            }
            else {
                return NotFound();
            }
        }

        // POST api/<ProjektyController>
        [HttpPost]
        public IActionResult Post(BaseNode department) {
            var context = new firmaContext();
            if (department.isValid()) {
                var newDepartment = department.baseToOddelenia();
                try {
                    context.Oddelenia.Add(newDepartment);
                    context.SaveChanges();
                    return Ok(newDepartment);

                }
                catch {
                    return BadRequest();
                }
            }
            return BadRequest("Some of the required data is missing!");
        }

        // PUT api/<ProjektyController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, BaseNode departmentChanges) {
            var context = new firmaContext();
            var department = context.Oddelenia.SingleOrDefault(x => x.Id == id);

            if (department != null) {
                if (!departmentChanges.isValid()) {
                    return BadRequest("Some of the data is missing!");
                }
                departmentChanges = departmentChanges.baseToOddelenia();
                department.Nazov = departmentChanges.Nazov;
                department.IdVeduci = departmentChanges.IdVeduci;
                department.IdPatriPod = departmentChanges.IdPatriPod;
                context.SaveChanges();
                return Ok(department);
            }
            else {
                return NotFound();
            }
        }

        // DELETE api/<ProjektyController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var context = new firmaContext();
            var departmentToRemove = context.Oddelenia.SingleOrDefault(x => x.Id == id);
            if (departmentToRemove != null) {
                context.Oddelenia.Remove(departmentToRemove);
                context.SaveChanges();
                return Ok(departmentToRemove);
            }
            else {
                return NotFound();
            }
        }
    }
}
