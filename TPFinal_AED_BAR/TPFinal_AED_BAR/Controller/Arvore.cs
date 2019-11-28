using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Controller
{
    class Arvore
    {
        No root = new No();
        int quantidade = 0;

        public No Root
        {
            get { return root; }
        }

        public string Quantidade
        {
            get { return quantidade.ToString(); }
        }

        public void Inserir(int valor)
        {
            No newNo = new No();
            newNo.setValor(valor);
            if (Root.getAnterior == null && root.getValor == null)
            {
                root.setValor(valor);
                root.setDireita(null);
                root.setEsquerda(null);
            }
            else
            {
                No aux = BuscarInsercao(valor);
                if (aux == null)
                {
                    Console.WriteLine("Valor existente - " + valor);
                }
                else
                {
                    if (valor > aux.getValor)
                    {
                        aux.setDireita(newNo);
                        newNo.setAnterior(aux);
                    }
                    else
                    {
                        aux.setEsquerda(newNo);
                        newNo.setAnterior(aux);
                    }
                }
            }
            quantidade++;
        }

        public void Excluir(No no, int? valor)
        {
            if (no == null)
            {
                Console.WriteLine("Não há nada para buscar!");
            }
            else
            {
                if (valor > no.getValor)
                {
                    Excluir(no.getDireita, valor);
                }
                else if (valor < no.getValor)
                {
                    Excluir(no.getEsquerda, valor);
                }
                else
                {
                    if (no.getDireita != null && no.getEsquerda != null)// se o nó possuir dois filhos
                    {
                        No aux = new No();
                        aux = no.getDireita;
                        while (aux.getEsquerda != null)// percorre até chegar ao nó mais a esquerda do nó a direita
                        {
                            aux = aux.getEsquerda;
                        }
                        no.setValor(aux.getValor);// torna o valor obtido em pai
                        Excluir(aux, aux.getValor);//aplica para o filho do novo pai
                        Console.WriteLine("Valor removido com sucesso!");
                        quantidade--;
                    }
                    else if (no.getDireita != null)//se só possuir o filho direito
                    {
                        SubstituirPaiNo(no.getDireita);
                    }
                    else if (no.getEsquerda != null)// se só possuir o filho esquerdo
                    {

                        SubstituirPaiNo(no.getEsquerda);
                    }
                    else//se não possuir filhos :(
                    {
                        if (no.getValor > no.getAnterior.getValor)
                        {
                            no.getAnterior.setDireita(null);
                        }
                        else
                        {
                            no.getAnterior.setEsquerda(null);
                        }
                    }
                }
            }
        }

        public void SubstituirPaiNo(No no)
        {
            if (no == no.getAnterior.getEsquerda)// se for o nó esquerdo
            {
                no.setAnterior(no.getAnterior.getAnterior);
                no.getAnterior.setEsquerda(no);// o filho esquerdo do pai vira null
            }
            else if (no == no.getAnterior.getDireita)// se for o nó direito
            {
                no.setAnterior(no.getAnterior.getAnterior);// o filho direito do pai vira null
                no.getAnterior.setDireita(no);
            }
        }

        public No Busca(No no, int valor)
        {
            if (no == null)
            {
                Console.WriteLine("Não Achei! " + valor.ToString());
                return null;
            }
            else
            {
                if (valor == no.getValor)
                {
                    Console.WriteLine("Achei! " + valor.ToString());
                    return no;
                }
                else if (valor < no.getValor)
                {
                    Busca(no.getEsquerda, valor);
                }
                else
                {
                    Busca(no.getDireita, valor);
                }
            }
            return null;
        }

        public No BuscarInsercao(int valor)
        {
            No no;
            no = Root;
            bool x = true;
            do
            {
                if (valor < no.getValor)
                {
                    if (no.getEsquerda == null)
                    {
                        x = false;
                        return no;
                    }
                    if (no.getEsquerda != null)
                    {
                        no = no.getEsquerda;
                    }
                }

                if (valor > no.getValor)
                {
                    if (no.getDireita == null)
                    {
                        x = false;
                        return no;
                    }
                    if (no.getDireita != null)
                    {
                        no = no.getDireita;
                    }
                }

                if (valor == no.getValor)
                {
                    return null;
                }
            } while (x);
            return null;
        }

        public int Maior(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public int Menor(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public int Altura(No no)
        {
            if ((no == null) || (no.getEsquerda == null && no.getDireita == null))
            {
                return 0;
            }
            else
            {
                return 1 + (Maior(Altura(no.getEsquerda), Altura(no.getDireita)));
            }
        }

        public int Profundidade(int k)
        {
            No aux;
            aux = root;

            int nivel = 0;
            while (aux != null && aux.getValor != k)
            {
                if (k < aux.getValor)
                {
                    aux = aux.getEsquerda;
                }
                else
                {
                    aux = aux.getDireita;
                }
                nivel++;
            }
            return nivel;
        }

        public Queue<No> Imprimir(No no)
        {
            //string noo;
            Queue<No> q = new Queue<No>();
            q.Enqueue(no);


            int? valorNo;

            while (q.Count != 0)
            {

                valorNo = (no = q.Dequeue() as No).getValor;

                if (no.getEsquerda != null)
                {
                    q.Enqueue(no.getEsquerda as No);
                }
                if (no.getDireita != null)
                {
                    q.Enqueue(no.getDireita as No);
                }
            }

            return q;
        }

        public void Padding(string pad, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(pad);
            }
        }

        public void print(No no, int level)
        {
            if (no == null)
            {
                Padding("  ", level);
                Console.WriteLine(" ");
            }
            else
            {
                print(no.getDireita, level + 1);
                Padding("  ", level);
                Console.Write(no.getValor);
                print(no.getEsquerda, level + 1);
            }
        }

        public void PreOrdem(No no)
        {
            if (no != null)
            {
                Console.Write(no.getValor + "  ");
                PreOrdem(no.getEsquerda);
                PreOrdem(no.getDireita);
            }
        }

        public void EmOrdem(No no)
        {
            if (no != null)
            {
                EmOrdem(no.getEsquerda);
                Console.Write(no.getValor + "  ");
                EmOrdem(no.getDireita);
            }
        }

        public void PosOrdem(No no)
        {
            if (no != null)
            {
                EmOrdem(no.getEsquerda);
                EmOrdem(no.getDireita);
                Console.Write(no.getValor + "  ");
            }
        }
    }
}
