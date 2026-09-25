using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/krediti")]
    public class KreditiController : ControllerBase
    {
        // GET api/krediti?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiKredite(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/krediti/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiKredit(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/krediti/racun/5?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("racun/{racunId:int}")]
        public IActionResult GetZaRacun(int racunId, int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiKrediteZaRacun(racunId, brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/krediti?jmbg=...&pib=...&racunId=5
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] KreditPregled k,
            [FromQuery] string brojRacuna)
        {
            if (k == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajKredit(k, brojRacuna);
                return Ok(k);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/krediti/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] KreditPregled k)
        {
            if (k == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (k.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                DataProvider.IzmeniKredit(k);
                return Ok(k);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/krediti/5
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                DataProvider.ObrisiKredit(id);
                return Ok("Uspešno brisanje.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
