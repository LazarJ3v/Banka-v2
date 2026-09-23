using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;


namespace BankaAPI.Controllers
{
    [Route("api/fizickalica")]
    public class FizickaLicaController : ControllerBase
    {
        // GET api/fizickalica?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiFizickaLica(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/fizickalica/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiFizickoLice(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/fizickalica
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] FizickoLicePregled fl)
        {
            if (fl == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajFizickoLice(fl);
                return Ok(fl); // vraća se sa generisanim Id
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/fizickalica/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] FizickoLicePregled fl)
        {
            if (fl == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (fl.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                var result = DataProvider.IzmeniFizickoLice(fl);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/fizickalica/5
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                DataProvider.ObrisiFizickoLice(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
