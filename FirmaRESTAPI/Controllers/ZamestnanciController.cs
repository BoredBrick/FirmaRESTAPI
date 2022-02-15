using Microsoft.AspNetCore.Mvc;
using FirmaRESTAPI.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirmaRESTAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ZamestnanciController : ControllerBase {
        // GET: api/<ZamestnanciController>
        [HttpGet]
        //public IQueryable<Firma> Get() {
        //    //using (var context = new firmaContext()) {
        //    //    return context.Zamestnanci;
        //    //}
        //    var context = new firmaContext();
        //    return context.Firma;
        //}

        public IQueryable<Zamestnanci> Get() {
            var context = new firmaContext();
            return context.Zamestnanci;
        }

        // GET api/<ZamestnanciController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
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
        public void Delete(int id) {
        }
    }
}
