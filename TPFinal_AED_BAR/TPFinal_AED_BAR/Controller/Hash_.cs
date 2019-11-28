using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Controller
{
    public class Hash_
    {
        private long M;
        private ListaHash[] tabela;
        private List<ListaHash> l = new List<ListaHash>();


        private long h(long chave)
        {
            return chave % this.M;
        }

        public Hash_(long m)
        {
            this.M = m;
            this.tabela = new ListaHash[this.M];
            for (int i = 0; i < this.M; i++)
            {
                this.tabela[i] = new ListaHash();
            }
        }

        public long Pesquisa(long chave)
        {
            long i = this.h(chave);

            if (this.tabela[i].Vazia())
            {
                return -1;
            }
            else
            {
                long item = this.tabela[i].PesquisaIndex(chave);
                if (item == -1)
                {
                    return -1;
                }
                else
                {
                    return item;
                }
            }
        }

        public void Insere(long chave)
        {
            if (this.Pesquisa(chave) == -1)
            {
                long i = this.h(chave);
                this.tabela[i].Insere(chave);
            }
            else
            {
                Console.WriteLine("Registro já está presente. ");
            }
        }

        public void Retira(long chave)
        {
            long i = this.h(chave);
            long item = this.tabela[i].Remove(chave);
            if (item == -1)
            {
                Console.WriteLine("Registro não está presente. ");
            }
        }

        public ListaHash[] Imprime()
        {
            for (int i = 0; i < this.M; i++)
            {
                if (!this.tabela[i].Vazia())
                {
                    l.Add(this.tabela[i]);
                }
            }

            return tabela;
        }

        public int returnQtde()
        {
            int qtde = 0;
            for (int i = 0; i < this.M; i++)
            {
                if (!this.tabela[i].Vazia())
                {
                    return qtde;
                }
                else if (this.tabela[i] != null)
                {
                    qtde++;
                }
            }
            return qtde;
        }
    }
}
