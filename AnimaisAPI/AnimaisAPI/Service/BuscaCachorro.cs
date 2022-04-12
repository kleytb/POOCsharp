using AnimaisAPI.Interfaces;
using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class BuscaCachorro : IBuscaCachorro
    {
        public  List<Cachorro> Busca()
        {
            var allLines = File.ReadAllLines(@"C:\Users\Kley\Desktop\LEITURABICHO.txt"); //Colocar aqui o caminho para busca do TXT, pode variar de máquina pra máquina            
            var listaCachorro = new List<Cachorro>(); // Crua uma lista com objetos Cachorro 
            foreach (var line in allLines)
            {
               var cachorro = CachorroParse.CreateFromLine(line);
               if(cachorro != null)
                    listaCachorro.Add(cachorro);
               continue;
            }
            return listaCachorro.ToList();
        }
    }
}

