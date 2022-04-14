using AnimaisAPI.Interfaces;
using AnimaisAPI.Models;
namespace AnimaisAPI.Service
{
    public class ListGato : IListGato
    {
        public List<Gato> ListaGato()
        {
            var allLines = Search.txtSearch();
            var listaGato = new List<Gato>();
            foreach(var line in allLines)
            {
                var gato = GatoParse.CreateFromLine(line);
                if(gato != null)
                    listaGato.Add(gato);
                continue;
            }
            foreach(var gato in listaGato)
            {
                BancoDeDados.AdicionarParametros(gato.Especie, gato.Raca, gato.Idade);
            }
            return listaGato;        
        }
    }
}


