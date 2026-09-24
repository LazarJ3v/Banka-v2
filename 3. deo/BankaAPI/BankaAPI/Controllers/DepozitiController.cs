using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/depoziti")]
    public class DepozitiController : ControllerBase
    {
        // GET api/depoziti?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiDepozite(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/depoziti/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiDepozit(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/depoziti/racun/5?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("racun/{racunId:int}")]
        public IActionResult GetZaRacun(int racunId, int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiDepoziteZaRacun(racunId, brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/depoziti?jmbg=...&pib=...&racunId=5
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] DepozitPregled d,
            [FromQuery] string brojRacuna)
        {
            if (d == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajDepozit(d, brojRacuna);
                return Ok(d);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/depoziti/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] DepozitPregled d)
        {
            if (d == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (d.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                DataProvider.IzmeniDepozit(d);
                return Ok(d);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/depoziti/5
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                DataProvider.ObrisiDepozit(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
