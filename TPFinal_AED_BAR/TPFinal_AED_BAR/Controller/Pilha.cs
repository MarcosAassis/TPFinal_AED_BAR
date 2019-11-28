using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Controller
{
    public class Pilha
    {
        private  Celula item;
        private List<Celula> celulas = new List<Celula>();
        private Celula prx;
        private int topo;
        public Pilha()
        {
            this.item = null;
            this.topo = 0;
        }

        public void empilha(object valor)
        {
            Celula aux = this.item;
            this.item = new Celula();
            this.item.item = valor;
            this.item.prx = aux;
            this.topo++;
        }

        public Object desempilha()
        {
            if (this.vazia())
                throw new Exception("Erro: A pilha está vazia");
            Object it = this.item.item;
            this.item = this.item.prx;
            this.topo--;
            return item;
        }
        public List<Celula> Imprime()
        {
            celulas.Clear();

            Celula aux = item.prx;

            if (aux != null)
            {
                celulas.Add(item);

                while (aux != null)
                {
                    aux = aux.prx;

                    celulas.Add(aux);
                }
            }
            else
                celulas.Add(item);

            return celulas;
        }
        public bool vazia()
        {
            return (this.topo == 0);
        }
        public int tamanho()
        {
            return this.topo;
        }
    }
}
