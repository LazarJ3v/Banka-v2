using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/racuni")]
    public class RacuniController : ControllerBase
    {
        // GET api/racuni?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiRacune(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/racuni/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiRacun(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/racuni/broj/170-1234567890123-45
        [HttpGet]
        [Route("broj/{brojRacuna}")]
        public IActionResult GetByBroj(string brojRacuna)
        {
            try
            {
                var result = DataProvider.VratiRacun(brojRacuna);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/racuni?jmbg=...&pib=...
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] RacunPregled r,
            [FromQuery] string jmbg = null, [FromQuery] string pib = null)
        {
            if (r == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajRacun(r, jmbg, pib);
                return Ok(r);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/racuni/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] RacunPregled r)
        {
            if (r == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (r.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                DataProvider.IzmeniRacun(r);
                return Ok(r);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/racuni/5
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                DataProvider.ObrisiRacun(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
