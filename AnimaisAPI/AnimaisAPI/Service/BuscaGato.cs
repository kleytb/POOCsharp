using AnimaisAPI.Interfaces;
using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class BuscaGato : IBuscaGato
    {
        public List<Gato> Busca()
        {
            var path = File.ReadAllLines(@"C:\Users\Kley\Desktop\LEITURABICHO.txt"); //Colocar aqui o caminho para busca do TXT, pode variar de máquina pra máquina
            var listaGato = new List<Gato>(); //Cria uma lista com objetos do tipo Gato
            foreach(var pathLine in path)
            {
                var gato = GatoParse.CreateFromLine(pathLine);
                if(gato != null)
                    listaGato.Add(gato);
                continue;
            }
            return listaGato.ToList();
            }
        }
}

