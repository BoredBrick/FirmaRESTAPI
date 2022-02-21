using FirmaRESTAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirmaRESTAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase {
        // GET: api/<FirmaController>
        [HttpGet]
        public IQueryable<Firma> GetCompanies() {
            var context = new firmaContext();
            return context.Firma;
        }




        // GET api/<FirmaController>/5
        [HttpGet("{id}")]
        public IActionResult GetCompany(int id) {
            var context = new firmaContext();
            var company = context.Firma.SingleOrDefault(x => x.Id == id);
            if (company != null) {
                return Ok(company);
            }
            else {
                return NotFound();
            }
        }

        // POST api/<FirmaController>
        [HttpPost]
        public IActionResult Post(FirmaNode company) {
            var context = new firmaContext();
            if (company.isValid()) {
                var newCompany = company.NodeToFirma();
                try {
                    context.Firma.Add(newCompany);
                    context.SaveChanges();
                    return Ok(newCompany);
                }
                catch {
                    return BadRequest();
                }
            }
            return BadRequest("Some of the required data is missing!");
        }

        // PUT api/<FirmaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, FirmaNode companyChanges) {
            var context = new firmaContext();
            var company = context.Firma.SingleOrDefault(x => x.Id == id);

            if (company != null) {
                if (!companyChanges.isValid()) {
                    return BadRequest("Some of the data is missing!");
                }
                company.Nazov = companyChanges.Nazov;
                company.IdVeduci = companyChanges.IdVeduci;
                context.SaveChanges();
                return Ok(company);
            }
            else {
                return NotFound();
            }
        }

        // DELETE api/<FirmaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var context = new firmaContext();
            var companyToRemove = context.Firma.SingleOrDefault(x => x.Id == id);
            if (companyToRemove != null) {
                context.Firma.Remove(companyToRemove);
                context.SaveChanges();
                return Ok(companyToRemove);
            }
            else {
                return NotFound();
            }
        }
    }
}
