using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarPOO
{
    internal class Gato : Animal //Classe gato herda os paramêtros da classe animal
    {
        public static void Validation()
        {
            var listaGato = new List<Gato>();
            var Gato = new Gato();
            if (Gato.Idade <= 5)           
                listaGato.Add(Gato);
            
            Console.WriteLine(String.Format("A quantidade de gatos importados é: {0}", listaGato.Count()));


        }
    }
}
