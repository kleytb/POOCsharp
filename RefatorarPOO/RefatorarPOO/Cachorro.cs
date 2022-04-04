using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarPOO
{
    internal class Cachorro : Animal //Classe cachorro herda os paramêtros da classe animal
    {
        
        public Cachorro(string raca, float idade)
        {
            if (idade <= 100)
            {
                Raca = raca;
                Idade = idade;
                
            }          
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

