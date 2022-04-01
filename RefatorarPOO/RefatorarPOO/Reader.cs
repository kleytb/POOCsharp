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
            var path = new StreamReader(@"C:\Users\Kley\Desktop\LEITURABICHO.txt"); //Colocar aqui o caminho para busca do TXT, pode variar de máquina pra máquina
            var listaGato = new List<Gato>(); //Cria uma lista com objetos do tipo Gato
            var listaCachorro = new List<Cachorro>(); // Crua uma lista com objetos Cachorro

            using (path) //Usando o path (caminho) ele executa os seguintes métodos
            {
                while (!path.EndOfStream)
                {
                    var pathLine = path.ReadLine();
                    if(pathLine == null)
                        break;
                    String [] line = pathLine.Split("|"); //Transforma a string pahtLine em um vetor
                    if (line[0].ToLower() == "gato")
                    {
                        var Gato = new Gato(); //Para cada objeto do tipo Gato, ele criar um novo objeto do tipo gato
                        Gato.Raca = line[1];
                        Gato.Idade = int.Parse(line[2]);
                        listaGato.Add(Gato);
                    }
                    else if (line[0].ToLower() == "cachorro")
                    {
                        var Cachorro = new Cachorro(); //Para cada objeto do tipo Cachorro, ele criar um novo objeto do tipo cachorro
                        Cachorro.Raca = line[1];
                        Cachorro.Idade = int.Parse(line[2]);
                        listaCachorro.Add(Cachorro);
                    }                    
                }
                int g = 0; 
                int c = 0;
                foreach (Gato gato in listaGato) //Parar contar quantos gatos e cachorros atendem as regras de negócio
                {
                    if(gato.Idade <= 5){
                        g++;
                    }
                }
                foreach (Cachorro cachorro in listaCachorro)
                {
                    if(cachorro.Idade <= 100)
                    {
                        c++;
                    }
                }

                Console.WriteLine("A quantidade de gatos com idade menor ou igual a 5 anos é: " + g);
                Console.WriteLine("A quantidade de cachorros com idade menor ou igual a 100 anos é: " + c);
            }
        }

       
    }
}
