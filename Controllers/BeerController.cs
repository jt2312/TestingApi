using ASPTesting.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPTesting.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly IBeerService _beerService;
        public BeerController(IBeerService service)
        {
            _beerService = service;
        }


        [HttpGet]
        public IActionResult Get() => Ok(_beerService.Get());
        [HttpGet]
        public IActionResult GetbyId(int id)
        {
            var beer = _beerService.Get(id);
            if (beer == null)
                return NotFound();
            return Ok(beer);
        }

    }
}
