using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria
{
    class interface IEstrategia
    {

         public Debitar(Cliente cliente, double)
        {

        }

        public Acreditar(Cliente cliente, double)
        {

        }

        public bool EsApto(Cliente cliente);
    }
}
