using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPFinal_AED_BAR.Controller
{
    class No
    {
        int? valor;
        No anterior, esquerda, direita;

        public int? getValor
        {
            get { return valor; }
        }

        public No getAnterior
        {
            get { return anterior; }
        }

        public No getDireita
        {
            get { return direita; }
        }

        public No getEsquerda
        {
            get { return esquerda; }
        }

        public void setValor(int? val)
        {
            valor = val;
        }

        public void setAnterior(No no)
        {
            anterior = no;
        }

        public void setDireita(No no)
        {
            direita = no;
        }

        public void setEsquerda(No no)
        {
            esquerda = no;
        }
    }

}
