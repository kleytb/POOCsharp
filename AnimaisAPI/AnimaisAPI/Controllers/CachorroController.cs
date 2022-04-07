using AnimaisAPI.Models;
using AnimaisAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimaisAPI.Controllers
{
    [Route("api/Animais/[controller]")]
    [ApiController]
    public class CachorroController : ControllerBase
    {
        public CachorroController()
        {
        }

        [HttpGet(Name = "Cachorros")]
        public List<Cachorro> Cachorros()
        {
            BuscaCachorro xpto = new BuscaCachorro();
            return xpto.Busca().ToList();
        }
    }
}
