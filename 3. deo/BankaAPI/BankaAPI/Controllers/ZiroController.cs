using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/ziro")]
    public class ZiroController : ControllerBase
    {
        // GET api/ziro/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiZiro(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/ziro?jmbg=...&pib=...
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] ZiroPregled z,
            [FromQuery] string jmbg = null, [FromQuery] string pib = null)
        {
            if (z == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajZiro(z, jmbg, pib);
                return Ok(z);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/ziro/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] ZiroPregled z)
        {
            if (z == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (z.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                DataProvider.IzmeniZiro(z);
                return Ok(z);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
