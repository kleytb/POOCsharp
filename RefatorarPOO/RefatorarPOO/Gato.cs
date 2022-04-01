using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarPOO
{
    internal class Gato : Animal //Classe gato herda os paramêtros da classe animal
    {
        public static bool Validation(int Idade)
        {
            if (Idade <= 5)
            {
                return true;
            }
            return false;
        }
    }
}
