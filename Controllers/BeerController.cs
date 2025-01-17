﻿using ASPTesting.Services;
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

        [HttpGet("{id}")]
        public IActionResult GetbyId(int Id)
        {
            var beer = _beerService.Get(Id);
            if (beer == null)
                return NotFound();
            return Ok(beer);
        }

    }
}
