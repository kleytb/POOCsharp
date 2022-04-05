using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorarPOO
{
    internal class TratamentoErro
    {
        public int E { get; set; }
        public TratamentoErro(int e)
        { 
            E = e;
        }
        public bool Erro()
        {
            if (E == 0)
                return false;
            return true;
        }
    }
}
