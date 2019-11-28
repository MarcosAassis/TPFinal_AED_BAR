using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Controller
{
    public class CelulaHash
    {
        public Object item;
        public CelulaHash prx;
        public CelulaHash()
        {
            item = null;
            prx = null;
        }

        public CelulaHash(object valor)
        {
            item = valor;
            prx = null;
        }

        public CelulaHash(object valor, CelulaHash proximo)
        {
            item = valor;
            prx = proximo;
        }
    }
}
