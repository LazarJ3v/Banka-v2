using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/tekuci")]
    public class TekuciController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiTekuce(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/tekuci/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiTekuci(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/tekuci?jmbg=...&pib=...
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] TekuciPregled t,
            [FromQuery] string jmbg = null, [FromQuery] string pib = null)
        {
            if (t == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajTekuci(t, jmbg, pib);
                return Ok(t);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/tekuci/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] TekuciPregled t)
        {
            if (t == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (t.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                DataProvider.IzmeniTekuci(t);
                return Ok(t);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/tekuci/5
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
