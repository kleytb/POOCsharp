using AnimaisAPI.Models;
using System.Globalization;

namespace AnimaisAPI.Service
{
    public class BuscaGato
    {
        public List<Gato> Busca()
        {
            int arraySize = 3; // Tamanho padrão do array definido pelas regras de negócio
            var path = new StreamReader(@"C:\Users\Kley\Desktop\LEITURABICHO.txt"); //Colocar aqui o caminho para busca do TXT, pode variar de máquina pra máquina
            var listaGato = new List<Gato>(); //Cria uma lista com objetos do tipo Gato
            var listaCachorro = new List<Cachorro>(); // Crua uma lista com objetos Cachorro               

            while (!path.EndOfStream)
            {
                var pathLine = path.ReadLine();
                if (pathLine == null)                
                    continue;
                String[] line = pathLine.Split("|"); //Transforma a string pahtLine em um vetor
                if (line.Length != arraySize) //Validação do tamanho padrão do array
                    continue;
                if (line[0].ToLower().Contains("gato"))
                {
                    if (float.TryParse(line[2], out float y))
                    {
                        var Gato = new Gato(line[1], y); //Para cada objeto do tipo Gato, ele criar um novo objeto do tipo gato
                        if (Gato.Valido())
                            listaGato.Add(Gato);
                    }

                    continue;
                }
                }
                return listaGato.ToList();
            }
        }

    }

