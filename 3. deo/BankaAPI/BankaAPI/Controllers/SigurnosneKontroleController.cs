using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/sigurnosnekontrole")]
    public class SigurnosneKontroleController : ControllerBase
    {
        // GET api/sigurnosnekontrole?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiSigurnosneKontrole(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/sigurnosnekontrole/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiSigurnosnuKontrolu(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/sigurnosnekontrole?racunId=5
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] SigurnosnaKontrolaPregled sk,
            [FromQuery] string brojRacuna)
        {
            if (sk == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajSigurnosnuKontrolu(sk, brojRacuna);
                return Ok(sk);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/sigurnosnekontrole/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] SigurnosnaKontrolaPregled sk)
        {
            if (sk == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (sk.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                DataProvider.IzmeniSigurnosnuKontrolu(sk);
                return Ok(sk);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/sigurnosnekontrole/5
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                DataProvider.ObrisiSigurnosnuKontrolu(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
