using AnimaisAPI.Models;
using AnimaisAPI.Service;
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

        [HttpGet("Animais", Name = "Animais")]
        public RetornoAnimais Todos ()
        {
            RetornoAnimais retornoAnimais = new RetornoAnimais();
            return retornoAnimais.Busca();
        }    

        [HttpGet("Gatos", Name ="Gatos")]
        public List<Gato> Gatos ()
        {
            BuscaGato buscaGato = new BuscaGato();
            return buscaGato.Busca().ToList();
        }
        [HttpGet("Cachorros", Name = "Cachorro")]
        public List<Cachorro> Cachorros()
        {
            BuscaCachorro xpto = new BuscaCachorro();
            return xpto.Busca().ToList();
        }

        [HttpPost("CreateGato", Name = "CreateGato")]

        public Gato Post(Gato gato)
        {
            AddGato.Create(gato);
            return gato;
        }

        [HttpPost("CreateCachorro", Name = "CreateCachorro")]

        public Cachorro Post(Cachorro cachorro)
        {
            AddCachorro.Create(cachorro);
            return cachorro;
        }
    }
}
