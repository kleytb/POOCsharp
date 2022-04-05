using System;
using System.Collections.Generic;
using System.Globalization;
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
            var listaErro = new List<TratamentoErro>();

            while (!path.EndOfStream)
            {                
                var pathLine = path.ReadLine();
                if (pathLine == null)
                {
                    //int e = 1;
                    //var erro = new TratamentoErro(e);
                    //if()
                    continue;

                }
                   
                String[] line = pathLine.Split("|"); //Transforma a string pahtLine em um vetor
                if (line.Length != arraySize) //Validação do tamanho padrão do array
                    continue;
                if (line[0].ToLower().Contains("gato"))
                {
                    if (float.TryParse(line[2], out float y))
                    {
                        var Gato = new Gato(line[1], y); //Para cada objeto do tipo Gato, ele criar um novo objeto do tipo gato
                        if(Gato.Valido())
                            listaGato.Add(Gato);
                    }    
                    
                    continue;
                }
                else if (line[0].ToLower().Contains("cachorro"))
                {                    
                    float y = float.Parse(line[2].Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat); // Conversão da idade de string para Float
                    var Cachorro = new Cachorro(line[1], y); //Para cada objeto do tipo Gato, ele criar um novo objeto do tipo gato
                    if(Cachorro.Valido())
                        listaCachorro.Add(Cachorro);
                }              
            }
            
            Console.WriteLine(String.Format("A quantidade de gatos importados é: {0}", listaGato.Count()));
            Console.WriteLine(String.Format("A quantidade de cachorros importados é: {0}", listaCachorro.Count()));
        }      
    }
}
