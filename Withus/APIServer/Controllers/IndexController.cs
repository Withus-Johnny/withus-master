using APIServer.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace APIServer.Controllers
{
    [Route("/")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly ILogger<IndexController> _logger;
        public IndexController(ILogger<IndexController> logger, WithusContext withusDB)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GET()
        {
            return Ok($"{DateTime.Now:yyyy.MM.dd dddd HH:mm:ss:ff}");
        }
    }
}
