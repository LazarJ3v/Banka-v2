using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/kamate")]
    public class KamateController : ControllerBase
    {
        // GET api/kamate?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiKamate(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/kamate/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiKamatu(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/kamate
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] KamataPregled k)
        {
            if (k == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajKamatu(k);
                return Ok(k);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/kamate/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] KamataPregled k)
        {
            if (k == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (k.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                DataProvider.IzmeniKamatu(k);
                return Ok(k);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/kamate/5
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                DataProvider.ObrisiKamatu(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
