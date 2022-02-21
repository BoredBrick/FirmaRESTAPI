using Microsoft.AspNetCore.Mvc;
using FirmaRESTAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirmaRESTAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProjektyController : ControllerBase {
        // GET: api/<ProjektyController>
        [HttpGet]
        public IQueryable<Projekty> Get() {
            var context = new firmaContext();
            return context.Projekty;
        }

        // GET api/<ProjektyController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var context = new firmaContext();
            var project = context.Projekty.SingleOrDefault(x => x.Id == id);
            if (project != null) {
                return Ok(project);
            }
            else {
                return NotFound();
            }
        }

        // POST api/<ProjektyController>
        [HttpPost]
        public IActionResult Post(ProjektySimple project) {
            var context = new firmaContext();
            if (project.isValid()) {
                var newProject = project.simpleToProject();
                try {
                    context.Projekty.Add(newProject);
                    context.SaveChanges();
                    return Ok(newProject);

                }
                catch {
                    return BadRequest();
                }
            }
            return BadRequest("Some of the required data is missing!");
        }

        // PUT api/<ProjektyController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, ProjektySimple projectChanges) {
            var context = new firmaContext();
            var project = context.Projekty.SingleOrDefault(x => x.Id == id);

            if (project != null) {
                if (!projectChanges.isValid()) {
                    return BadRequest("Some of the data is missing!");
                }
                project.Nazov = projectChanges.Nazov;
                project.IdVeduciProj = projectChanges.IdVeduciProj;
                project.IdPatriPod = projectChanges.IdPatriPod;
                context.SaveChanges();
                return Ok(project);
            }
            else {
                return NotFound();
            }
        }

        // DELETE api/<ProjektyController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var context = new firmaContext();
            var projectToRemove = context.Projekty.SingleOrDefault(x => x.Id == id);
            if (projectToRemove != null) {
                context.Projekty.Remove(projectToRemove);
                context.SaveChanges();
                return Ok(projectToRemove);
            }
            else {
                return NotFound();
            }
        }
    }
}
