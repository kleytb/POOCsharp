using AnimaisAPI.Interfaces;
using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class ListCachorro : IListCachorro
    {
        public  List<Cachorro> ListaCachorro()
        {
            var allLines = TxtSearch.Search();
            var listaCachorro = new List<Cachorro>(); 
            foreach (var line in allLines)
            {
               var cachorro = CachorroParse.CreateFromLine(line);
               if(cachorro != null)
                    listaCachorro.Add(cachorro);
               continue;
            }
            foreach (var cachorro in listaCachorro)
            {
                BancoDeDados.Insert(cachorro.Especie, cachorro.Raca, cachorro.Idade);
            }
            return listaCachorro.ToList();
        }
    }
}

