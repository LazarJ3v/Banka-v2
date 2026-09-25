using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BankaAPI.Controllers
{
    [Route("api/transakcije")]
    public class TransakcijeController : ControllerBase
    {
        // GET api/transakcije?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("")]
        public IActionResult GetAll(int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiTransakcije(brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/transakcije/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = DataProvider.VratiTransakciju(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/transakcije/racun/5?brojPoStrani=10&strana=1
        [HttpGet]
        [Route("racun/{racunId:int}")]
        public IActionResult GetZaRacun(int racunId, int brojPoStrani = 10, int strana = 1)
        {
            try
            {
                var result = DataProvider.VratiTransakcijeZaRacun(racunId, brojPoStrani, strana);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/transakcije?racunId=5
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] TransakcijaPregled t,
            [FromQuery] string brojRacuna)
        {
            if (t == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.DodajTransakciju(t, brojRacuna);
                return Ok(t);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/transakcije/5
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] TransakcijaPregled t)
        {
            if (t == null)
                return BadRequest("Podaci nisu prosleđeni.");

            if (t.Id != id)
                return BadRequest("Id u URL-u i u telu se ne poklapaju.");

            try
            {
                DataProvider.IzmeniTransakciju(t);
                return Ok(t);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/transakcije/5
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                DataProvider.ObrisiTransakciju(id);
                return Ok("Uspešno brisanje.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/transakcije/transfer
        [HttpPost]
        [Route("transfer")]
        public IActionResult Transfer([FromBody] TransferRequest request)
        {
            if (request == null)
                return BadRequest("Podaci nisu prosleđeni.");

            try
            {
                DataProvider.IzvrsiTransferIzmedjuRacuna(
                    request.RacunPosiljaocaId,
                    request.RacunPrimaocaId,
                    request.Iznos,
                    request.Opis,
                    request.Komentar);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

    public class TransferRequest
    {
        public int RacunPosiljaocaId { get; set; }
        public int RacunPrimaocaId { get; set; }
        public decimal Iznos { get; set; }
        public string Opis { get; set; }
        public string Komentar { get; set; }
    }
}
