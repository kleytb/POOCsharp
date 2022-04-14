using AnimaisAPI.Interfaces;
using AnimaisAPI.Service;

namespace AnimaisAPI.Models
{
    public class ListAnimals : IListAnimals
    {
        public List<Cachorro>? cachorros { get; set; }
        public List<Gato>? gatos { get; set; }

        public ListAnimals ListaAnimais()
        {
            ListAnimals listaAnimais = new ListAnimals();
            ListGato listaGato = new ListGato();
            ListCachorro listaCachorro = new ListCachorro();
            listaAnimais.gatos = listaGato.ListaGato();
            listaAnimais.cachorros = listaCachorro.ListaCachorro();
            
            foreach (var gato in listaAnimais.gatos)
            {
                BancoDeDados.AdicionarParametros(gato.Especie, gato.Raca, gato.Idade);
            }
            foreach (var cachorro in listaAnimais.cachorros)
            {
                BancoDeDados.AdicionarParametros(cachorro.Especie, cachorro.Raca, cachorro.Idade);
            }

            return listaAnimais;
        }
    }
}

   