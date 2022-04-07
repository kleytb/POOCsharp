using AnimaisAPI.Models;
using AnimaisAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimaisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        public AnimaisController()
        {
        }

        [HttpGet(Name = "Animais")]
        public List<Animal> Animais()
        {
            BuscaAnimais xpto = new BuscaAnimais();
            return xpto.Busca().ToList();
        }
    }
}
