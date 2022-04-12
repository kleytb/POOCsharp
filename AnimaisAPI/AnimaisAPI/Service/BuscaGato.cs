using AnimaisAPI.Interfaces;
using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class BuscaGato : IBuscaGato
    {
        public List<Gato> Busca()
        {
            var allLines = File.ReadAllLines(@"C:\Users\Kley\Desktop\LEITURABICHO.txt"); 
            var listaGato = new List<Gato>(); 
            foreach(var line in allLines)
            {
                var gato = GatoParse.CreateFromLine(line);
                if(gato != null)
                    listaGato.Add(gato);
                continue;
            }
            return listaGato.ToList();
            }
        }
}

