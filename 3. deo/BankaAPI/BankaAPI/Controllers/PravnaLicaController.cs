using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/pravnalica")]
    public class PravnaLicaController : ControllerBase
    {
        // GET api/pravnalica?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiPravnaLica(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/pravnalica/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiPravnoLice(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/pravnalica
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] PravnoLicePregled pl)
        {
            if (pl == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajPravnoLice(pl);
                return Ok(pl);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/pravnalica/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] PravnoLicePregled pl)
        {
            if (pl == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (pl.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                var result = DataProvider.IzmeniPravnoLice(pl);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/pravnalica/5
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                DataProvider.ObrisiPravnoLice(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
