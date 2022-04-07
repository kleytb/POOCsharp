using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class BuscaAnimais
    {
        public List<Animal> Busca()
        {
            var listaAnimais = new List<Animal>();              
            var animal = new Animal();
            var buscaCachorro = new BuscaCachorro();
            var buscaGato = new BuscaGato();
            
            listaAnimais.Add(animal);
            
            

            return listaAnimais.ToList();
        }
    }
}
