using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Controller
{
    public class Fila
    {
        private Celula Frente; 
        private Celula Tras;
        private bool slv;
        private int Qtde = 0;
        private List<Celula> fila = new List<Celula>();

        /// <summary>
        /// Funηγo construtora. Cria a cιlula cabeηa e faz as referκncias Frente e Tras apontarem para ela.
        /// </summary>
        public Fila()
        {
            Frente = new Celula();
            Tras = Frente;
        }

        /// <summary>
        /// Verifica se a fila estα vazia
        /// </summary>
        /// <returns>Retorna TRUE se a lista estiver vazia e FALSE caso contrαrio.</returns>
        public bool Vazia()
        {
            return Frente == Tras;
        }

        /// <summary>
        /// Insere um novo item no fim da fila.
        /// </summary>
        /// <param name="Valoritem">Um Object contendo o elemento a ser inserido no final da fila.</param>
        public void Enfileira(Object Valoritem)
        {
            Tras.prx = new Celula(Valoritem);
            Tras = Tras.prx;
            Qtde++;
        }

        public List<Celula> Imprime()
        {
            fila.Clear();

            Celula aux = Frente.prx;

            if (aux != null)
            {
                fila.Add(Frente);

                while (aux != null)
                {
                    aux = aux.prx;

                    fila.Add(aux);
                }
            }
            else
                fila.Add(Frente);

            return fila;
        }

        /// <summary>
        /// Retira e retorna o primeiro elemento da fila.
        /// </summary>
        /// <returns>Um Object contendo o primeiro elemento da fila. Caso a fila esteja vazia retorna null.</returns>
        public Object Desenfileira()
        {
            Object item = null;
            if (Frente != Tras)
            {
                Frente = Frente.prx;
                item = Frente.item;
                Qtde--;
            }
            return item;
        }

        /// <summary>
        /// Retorna o primeiro item da fila sem removκ-lo.
        /// </summary>
        /// <returns>Um Object contendo o primeiro item da fila.</returns>
        public Object Peek()
        {
            if (Frente != Tras)
                return Frente.prx.item;
            else
                return null;
        }

        /// <summary>
        /// Verifica se o item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">Um object contendo o item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o item esteja presente na lista.</returns>
        public bool Contem(Object elemento)
        {
            bool achou = false;
            Celula aux = Frente.prx;
            while (aux != null && !achou)
            {
                achou = aux.item.Equals(elemento);
                aux = aux.prx;
            }
            return achou;
        }

        /// <summary>
        /// Verifica se o item passado como parβmetro estα contido na lista. (Obs: usa o comando FOR)
        /// </summary>
        /// <param name="elemento">Um object contendo o item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o item esteja presente na lista.</returns>
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (Celula aux = Frente.prx; aux != null && !achou; aux = aux.prx)
                achou = aux.item.Equals(elemento);
            return achou;
        }

        /// <summary>
        /// Funηγo que retorna a quantidade de itens da fila.
        /// </summary>
        /// <returns>Quantidade de itens da fila.</returns>
        public int Quantidade() //Funηγo
        {
            return Qtde;
        }

        /// <summary>
        /// Torna possνvel iterar sobre a CFila usando o comando foreach
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (Celula aux = Frente.prx; aux != null; aux = aux.prx)
                yield return aux.item;
        }
    }
}
