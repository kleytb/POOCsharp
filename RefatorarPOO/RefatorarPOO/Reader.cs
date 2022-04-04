using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarPOO
{
    internal class Reader
    {
        public static void Read()
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
                if (line[0].ToLower() == "gato")
                {                    
                    var Gato = new Gato(); //Para cada objeto do tipo Gato, ele criar um novo objeto do tipo gato
                    Gato.Raca = line[1];
                    Gato.Idade = int.Parse(line[2]);
                    if (Gato.Validation(int.Parse(line[2])))
                        listaGato.Add(Gato);
                }
                else if (line[0].ToLower() == "cachorro")
                {
                    var Cachorro = new Cachorro(); //Para cada objeto do tipo Cachorro, ele criar um novo objeto do tipo cachorro
                    Cachorro.Raca = line[1];
                    Cachorro.Idade = int.Parse(line[2]);
                    if (Cachorro.Validation(int.Parse(line[2])))
                        listaCachorro.Add(Cachorro);
                }                
            }           
            Console.WriteLine(String.Format("A quantidade de gatos importados é: {0}", listaGato.Count()));
            Console.WriteLine(String.Format("A quantidade de cachorros importados é: {0}", listaCachorro.Count()));
        }      
    }
}
