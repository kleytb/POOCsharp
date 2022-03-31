using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerTxt
{
    internal class Reader
    {
        public static void Read()
        {
            var path = new StreamReader(@"C:\Users\Kley\Desktop\LEITURABICHO.txt");
            var listaGatos = new List<Gato>();
            var listaCachorro = new List<Cachorro>();
            using (path)
            {
                while (!path.EndOfStream)
                {
                    var pathLine = path.ReadLine();
                    if (pathLine == null)
                    {
                        break;
                    }
                    String[] linha = pathLine.Split("|");

                    if (linha[0].Equals("GATO"))
                    {

                        var gato = new Gato();
                        gato.Raca = linha[1];
                        gato.Idade = int.Parse(linha[2]);
                        listaGatos.Add(gato);

                    }
                    else
                    {
                        var cachorro = new Cachorro();
                        cachorro.Raca = linha[1];
                        cachorro.Idade = int.Parse(linha[2]);
                        listaCachorro.Add(cachorro);
                    }
                }
            }

            int g = 0;
            int c = 0;
            foreach (Gato gato in listaGatos)
            {
                
                if(gato.Idade <= 5)
                {
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

            Console.WriteLine("A quantidade de Gatos com idade menor que 6 é " + g);
            Console.WriteLine("A quantidade de Cachorros com idade menor de 101 anos é " + c);
        }
    }
}
