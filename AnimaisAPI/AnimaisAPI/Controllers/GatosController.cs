using AnimaisAPI.Models;
using AnimaisAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimaisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GatosController : ControllerBase
    {
        public GatosController()
        {
        }

        [HttpGet(Name = "Gatos")]
        public List<Gato> Animais()
        {
            BuscaGato xpto = new BuscaGato();
            return xpto.Busca().ToList();
        }
    }
}
