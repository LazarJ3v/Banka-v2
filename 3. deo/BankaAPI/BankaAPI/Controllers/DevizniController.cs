using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/devizni")]
    public class DevizniController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiDevizne(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/devizni/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiDevizni(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/devizni?jmbg=...&pib=...
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] DevizniPregled d,
            [FromQuery] string jmbg = null, [FromQuery] string pib = null)
        {
            if (d == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajDevizni(d, jmbg, pib);
                return Ok(d);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/devizni/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] DevizniPregled d)
        {
            if (d == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (d.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                DataProvider.IzmeniDevizni(d);
                return Ok(d);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/devizni/5
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                DataProvider.ObrisiRacun(id);
                return Ok("Uspešno brisanje.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
