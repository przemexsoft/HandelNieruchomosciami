using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandelNieruchomosciami.Controllers.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandelNieruchomosciami.Controllers
{
    [Produces("application/json")]
    [Route("api/Wlasciciel")]

    public class WlascicielController : Controller
    {
        private readonly IWlascicielRepository _wlascicielRepository;

        public WlascicielController(IWlascicielRepository wlascicielRepository)
        {
            _wlascicielRepository = wlascicielRepository;
        }

        [HttpGet("action")]
        public IActionResult GetWlasciciels()
        {
            return new JsonResult(_wlascicielRepository.GetAll());
        }
    }
}