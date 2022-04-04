using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarPOO
{
    internal class Gato : Animal //Classe gato herda os paramêtros da classe animal
    { 
        public Gato(string raca, float idade)
        {        
             Raca = raca;
             Idade = idade;    
        } 
        public bool Valido()
        {
            if (Idade > 5)
                return false;
            if (string.IsNullOrEmpty(Raca))
                return false;
            return true;
        }
    }
}
