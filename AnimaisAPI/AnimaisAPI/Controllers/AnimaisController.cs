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
        public ListAnimals Todos ()
        {
            ListAnimals retornoAnimais = new ListAnimals();
            return retornoAnimais.ListaAnimais();
        }   
        [HttpGet("Gatos", Name ="Gatos")]
        public List<Gato> Gatos ()
        {
            ListGato buscaGato = new ListGato();
            return buscaGato.ListaGato().ToList();
        }
        [HttpGet("Cachorros", Name = "Cachorro")]
        public List<Cachorro> Cachorros()
        {
            ListCachorro xpto = new ListCachorro();
            return xpto.ListaCachorro().ToList();
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
