using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class BuscaAnimais
    {
        public List<Animal> Busca()
        {
            var listaAnimais = new List<Animal>(); 
            var buscaCachorro = new BuscaCachorro();
            var buscaGato = new BuscaGato();
            listaAnimais.AddRange(buscaCachorro.Busca());
            listaAnimais.AddRange(buscaGato.Busca());
            return listaAnimais.ToList();
        }
    }
}
