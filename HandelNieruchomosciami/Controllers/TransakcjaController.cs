using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandelNieruchomosciami.Controllers.Models.Interfaces;

namespace HandelNieruchomosciami.Controllers
{
    [Produces("application/json")]
    [Route("api/Transakcja")]

    public class TransakcjaController : Controller
    {
        //warstwa abstrakcji

        private readonly ITransakcjaRepository _transakcjaRepository;

        public TransakcjaController(ITransakcjaRepository transakcjaRepository)
        {
            _transakcjaRepository = transakcjaRepository;
        }

        [HttpGet("action")]
        public IActionResult GetTransacties()
        {
            return new JsonResult(_transakcjaRepository.GetAll());
        }

    }
}