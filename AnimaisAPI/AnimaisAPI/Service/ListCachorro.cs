using AnimaisAPI.Interfaces;
using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class ListCachorro : IListCachorro
    {
        public List<Cachorro> ListaCachorro()
        {
            var allLines = Search.txtSearch();
            var listaCachorro = new List<Cachorro>();
            foreach (var line in allLines)
            {
                var cachorro = CachorroParse.CreateFromLine(line);
                if (cachorro != null)
                    listaCachorro.Add(cachorro);
                continue;
            }

            foreach (var cachorro in listaCachorro)
            {
                BancoDeDados.AdicionarParametros(cachorro.Especie, cachorro.Raca, cachorro.Idade);
            }
            return listaCachorro;
        }
    }
}

