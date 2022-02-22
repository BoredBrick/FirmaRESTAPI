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
            if (project is null) {
                return NotFound();
            }
            else {
                return Ok(project);
            }
        }

        // POST api/<ProjektyController>
        [HttpPost]
        public IActionResult Post(BaseNode project) {
            if (!project.isValid()) {
                return BadRequest("Some of the required data is missing!");
            }

            var context = new firmaContext();
            var newProject = project.baseToProjekty();
            try {
                context.Projekty.Add(newProject);
                context.SaveChanges();
                return Ok(newProject);
            }
            catch {
                return BadRequest();
            }
        }

        // PUT api/<ProjektyController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, BaseNode projectChanges) {
            if (!projectChanges.isValid()) {
                return BadRequest("Some of the data is missing!");
            }

            var context = new firmaContext();
            var project = context.Projekty.SingleOrDefault(x => x.Id == id);
            if (project is null) {
                return NotFound();
            }

            projectChanges = projectChanges.baseToProjekty();
            project.Nazov = projectChanges.Nazov;
            project.IdVeduci = projectChanges.IdVeduci;
            project.IdPatriPod = projectChanges.IdPatriPod;
            context.SaveChanges();
            return Ok(project);
        }

        // DELETE api/<ProjektyController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var context = new firmaContext();
            var projectToRemove = context.Projekty.SingleOrDefault(x => x.Id == id);
            if (projectToRemove is null) {
                return NotFound();
            }
            context.Projekty.Remove(projectToRemove);
            context.SaveChanges();
            return Ok(projectToRemove);
        }
    }
}
