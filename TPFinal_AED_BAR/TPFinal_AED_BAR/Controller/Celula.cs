using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Controller
{
    public class Celula
    {
        public Object item;
        public Celula prx;
        public Celula()
        {
            item = null;
            prx = null;
        }

        public Celula(object valor)
        {
            item = valor;
            prx = null;
        }

        public Celula(object valor, Celula proximo)
        {
            item = valor;
            prx = proximo;
        }
    }
}
