using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Controller
{
    public class Lista
    {
        private Celula Primeira; 
        private Celula Ultima; 
        ArrayList AL = new ArrayList();
        List<Celula> celulas = new List<Celula>();
        private int Qtde = 0;

        public Lista()
        {
            Primeira = new Celula();
            Ultima = Primeira;
        }

        public bool Vazia()
        {
            return Primeira == Ultima;
        }

        public long Pesquisa(long chave)
        {
            if (this.Vazia())
            {
                Celula aux = Primeira.prx;

                while (aux != null)
                {
                    if (aux.item.Equals(chave))
                        return (long)aux.item;
                    aux = aux.prx;
                }
            }
            return -1;
        }

        public long PesquisaIndex(long chave)
        {
            int i = 0;
            if (this.Vazia())
            {
                Celula aux = Primeira.prx;

                while (aux != null)
                {
                    if (i == chave)
                        return (long)aux.item;
                    aux = aux.prx;

                    i++;
                }
            }
            return -1;
        }


        public void InsereDepoisDe(Object ElementoAInserir, Object Elemento)
        {
            bool achou = false;
            Celula aux = Primeira.prx;
            int indice = 0;
            while (aux.prx != null && !achou)
            {
                achou = aux.item.Equals(Elemento);
                indice++;
                aux = aux.prx;
            }
            InsereIndice(ElementoAInserir, indice);
        }

        public void InsereAntesDe(Object ElementoAInserir, Object Elemento)
        {
            bool achou = false;
            Celula aux = Primeira.prx;
            int indice = 0;
            while (aux.prx != null && !achou)
            {
                achou = aux.item.Equals(Elemento);
                indice++;
                aux = aux.prx;
            }
            InsereIndice(ElementoAInserir, (indice + 1));
        }

        public void Insere(Object Valoritem)
        {
            Ultima.prx = new Celula(Valoritem);
            Ultima = Ultima.prx;
            Qtde++;
        }

        public void InsereComeco(Object Valoritem)
        {
            Primeira.prx = new Celula(Valoritem, Primeira.prx);
            if (Primeira.prx.prx == null)
                Ultima = Primeira.prx;
            Qtde++;
        }

        
        public void InsereOrdenado(int ElementoAInserir)
        {
            AL.Add(ElementoAInserir);
            AL.Sort();

            Limpa();

            foreach (int item in AL)
            {
                Insere(item);
            }
        }

        public int Maior()
        {
            Celula aux = Primeira.prx;
            int maior = (int)Primeira.prx.item;
            while (aux != null)
            {
                int n = (int)aux.item;
                if (n > maior)
                {
                    maior = (int)aux.item;
                }
                aux = aux.prx;
            }
            return maior;
        }

        public int Menor()
        {
            Celula aux = Primeira.prx;
            int menor = (int)Primeira.prx.item;
            while (aux != null)
            {
                int n = (int)aux.item;
                if (n < menor)
                {
                    menor = (int)aux.item;
                }
                aux = aux.prx;
            }
            return menor;
        }

        public bool InsereIndice(Object Valoritem, int Posicao)
        {
            if (Posicao >= 1 && Posicao <= Qtde + 1)
            {
                int i = 0;
                Celula aux = Primeira;
               
                while (i < Posicao - 1)
                {
                    aux = aux.prx;
                    i++;
                }
                aux.prx = new Celula(Valoritem, aux.prx);
                if (aux.prx.prx == null) 
                    Ultima = aux.prx;
                Qtde++;
                return true;
            }
            return false;
        }

        public void Imprime(bool itemPorLinha)
        {
            Celula aux = Primeira.prx;
            while (aux != null)
            {
                Console.WriteLine(aux.item);
                aux = aux.prx;
            }
        }

        public void ImprimeFor()
        {
            for (Celula aux = Primeira.prx; aux != null; aux = aux.prx)
                Console.Write(aux.item);
        }

        public void ImprimeFormatoLista()
        {
            Console.WriteLine();
            Console.Write("[/]->");
            for (Celula aux = Primeira.prx; aux != null; aux = aux.prx)
                Console.Write("[" + aux.item.ToString() + "]->");
            Console.WriteLine("null");
        }

        public bool Contem(Object elemento)
        {
            bool achou = false;
            Celula aux = Primeira.prx;
            while (aux != null && !achou)
            {
                achou = aux.item.Equals(elemento);
                aux = aux.prx;
            }
            return achou;
        }

        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (Celula aux = Primeira.prx; aux != null && !achou; aux = aux.prx)
                achou = aux.item.Equals(elemento);
            return achou;
        }

        public Object RemoveRetornaComeco()
        {
            
            if (Primeira != Ultima)
            {
                Celula aux = Primeira.prx;
                Primeira.prx = aux.prx;
                if (Primeira.prx == null)
                    Ultima = Primeira;
                Qtde--;
                return aux.item;
            }
            return null;
        }

        public Object RemoveRetornaComecoSimples()
        {
            
            if (Primeira != Ultima)
            {
                Primeira = Primeira.prx;
                Qtde--;
                return Primeira.item;
            }
            return null;
        }

        public void RemoveComecoSemRetorno()
        {
            if (Primeira != Ultima)
            {
                Primeira = Primeira.prx;
                Qtde--;
            }
        }

        public Object RemoveRetornaFim()
        {
            if (Primeira != Ultima)
            {
                Celula aux = Primeira;
                while (aux.prx != Ultima)
                    aux = aux.prx;

                Celula aux2 = aux.prx;
                Ultima = aux;
                Ultima.prx = null;
                Qtde--;
                return aux2.item;
            }
            return null;
        }

        public void RemoveFimSemRetorno()
        {
            if (Primeira != Ultima)
            {
                Celula aux = Primeira;
                while (aux.prx != Ultima)
                    aux = aux.prx;

                Ultima = aux;
                Ultima.prx = null;
                Qtde--;
            }
        }

        public int Remove(Object Valoritem) 
        {
            if (Primeira != Ultima)
            {
                Celula aux = Primeira;
                bool achou = false;
                while (aux.prx != null && !achou)
                {
                    achou = aux.prx.item.Equals(Valoritem);
                    if (!achou)
                        aux = aux.prx;
                    else 
                        return (int)aux.item; 
                }
                if (achou) 
                {
                    aux.prx = aux.prx.prx;
                    if (aux.prx == null)
                        Ultima = aux;
                    Qtde--;
                }
            }
            return -1; 
        }

        public Object RetornaPrimeiro()
        {
            if (Primeira != Ultima)
                return Primeira.prx.item;
            else
                return null;
        }

        public Object RetornaUltimo()
        {
            if (Primeira != Ultima)
                return Ultima.item;
            else
                return null;
        }

        public Object RetornaIndice(int Posicao)
        {
            if ((Posicao >= 1) && (Posicao <= Qtde) && (Primeira != Ultima))
            {
                int i = 1;
                Celula aux = Primeira.prx;
                while (i < Posicao)
                {
                    aux = aux.prx;
                    i++;
                }
                return aux.item;
            }
            return null;
        }

        public int Quantidade()
        {
            return Qtde;
        }

        public IEnumerator GetEnumerator()
        {
            for (Celula aux = Primeira.prx; aux != null; aux = aux.prx)
                yield return aux.item;
        }

        public void Limpa()
        {
            Primeira = new Celula();
            Ultima = Primeira;
            Qtde = 0;
        }

        public List<Celula> Imprime()
        {
            celulas.Clear();

            Celula aux = Primeira.prx;
            if (aux != null)
            {
                celulas.Add(Primeira);

                while (aux != null)
                {
                    aux = aux.prx;
                    celulas.Add(aux);
                }
            }
            else
                celulas.Add(Primeira);

            return celulas;
        }

        public List<Celula> ImprimeTabela(long i)
        {
            Celula aux = Primeira.prx;
            if (aux != null)
            {
                celulas.Add(Primeira);

                while (aux != null)
                {
                    aux = aux.prx;
                    celulas.Add(aux);
                }
            }
            else
                celulas.Add(Primeira);

            return celulas;
        }
    }
}
