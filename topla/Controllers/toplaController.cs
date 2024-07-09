using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace topla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class toplaController : ControllerBase
    {
        [HttpPost("islem1")]
        public IActionResult islem1(int x, int y)
        {
            int topla = x + y;
            return Ok(topla);
        }

        [HttpGet("islem2")]
        public int Islem2 (int x , int y)
        {
            return x + y;
        }

        [HttpPost("islem3")]
        public IActionResult islem3([FromBody] Sayi sayi)
        {
            int toplam = sayi.A + sayi.B;
            return Ok(toplam);
        }

        public class Sayi
        {
            public int A { get; set; }
            public int B { get; set; }
        }

        [HttpPost("islem4")]
        public JsonResult islem4(int x, int y)
        {
            int topla = x + y;
            return new JsonResult(topla);
        }

        [HttpPost("islem5")]
        public ContentResult Islem5(int x, int y)
        {
            int topla = x + y;
            return new ContentResult
            {
                Content = topla.ToString(),
            };
        }
    }
}
