using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pamukkaleEdu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pamukkaleEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrencilerController : ControllerBase
    {
        private IOgrenciServisi ogrenciServisi;

        public OgrencilerController(IOgrenciServisi ogrenciServisi)
        {
            this.ogrenciServisi = ogrenciServisi;
        }
        [HttpGet]
        public async Task<IActionResult> TumOgrencileriGetir()
        {
            var ogrenciler = await ogrenciServisi.OgrencileriGetir();
            return Ok(ogrenciler);
        }

        [HttpGet("{ogrenciNo}")]
        public async Task<IActionResult> OgrenciNoyaGoreAra([FromRoute]string ogrenciNo)
        {
            if (string.IsNullOrEmpty(ogrenciNo))
            {
                return BadRequest(new { message ="ogrenci numarası belirtilmeli" });
            }

           var result = await ogrenciServisi.OgrenciNoyaGoreOgrenciGetir(ogrenciNo);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
