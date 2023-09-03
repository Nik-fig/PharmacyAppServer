using Microsoft.AspNetCore.Mvc;
using PharmacyAppServer.DA;
using PharmacyAppServer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PharmacyAppServer.Controllers
{
    [Route("api/drugs")]
    [ApiController]
    public class DrugContoller : ControllerBase
    {
        // GET api/<DrugContoller>/all
        [HttpGet("all")]
        public IActionResult Get(ApplicationContext db)
        {
            var drugs = db.Drugs.ToList();
            return new JsonResult(drugs);
        }

        // GET api/<DrugContoller>/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id, ApplicationContext db)
        {
            var drug = db.Drugs.FirstOrDefault(d => d.Id == id);
            if (drug == null)
                return NotFound();
            return new JsonResult(drug);
        }


        // POST api/<DrugContoller>
        [HttpPost]
        public IActionResult Post(Drug drug, ApplicationContext db)
        {
            db.Add(drug);
            db.SaveChanges();
            return Created($"/drugs/{drug.Id}", drug);
        }

        // PUT api/<DrugContoller>
        [HttpPut]
        public IActionResult Put(Drug drug, ApplicationContext db)
        {
            if (drug == null)
            {
                return BadRequest();
            }
            if (db.Drugs.FirstOrDefault(dr => dr.Id == drug.Id) == null)
            {
                return NotFound();
            }

            db.Update(drug);
            db.SaveChanges();
            return Ok(drug);
        }

        // DELETE api/<DrugContoller>/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, ApplicationContext db)
        {
            var drug = db.Drugs.FirstOrDefault(dr => dr.Id == id);
            if (drug == null)
            {
                return NotFound();
            }
            db.Drugs.Remove(drug);
            db.SaveChanges();
            return Ok(drug);
        }
    }
}
