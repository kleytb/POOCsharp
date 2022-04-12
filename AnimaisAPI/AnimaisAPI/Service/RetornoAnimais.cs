using AnimaisAPI.Interfaces;
using AnimaisAPI.Service;

namespace AnimaisAPI.Models
{
    public class RetornoAnimais : IRetornoAnimais
    {
        public List<Cachorro>? cachorros { get; set; }
        public List<Gato>? gatos { get; set; }

        public RetornoAnimais Busca()
        {
            RetornoAnimais retornoAnimais = new RetornoAnimais();
            BuscaGato buscaGato = new BuscaGato();
            BuscaCachorro buscaCachorro = new BuscaCachorro();
            retornoAnimais.gatos = buscaGato.Busca();
            retornoAnimais.cachorros = buscaCachorro.Busca();
            return retornoAnimais;
        }
    }
}

   