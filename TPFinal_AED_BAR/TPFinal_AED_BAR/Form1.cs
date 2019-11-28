/*Alunos:
 * Amanda Brasil
 * Fabio Alves
 * Isabela Meira
 * Marcos Assis
 */

using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFinal_AED_BAR.Controller;

namespace TPFinal_AED_BAR
{
    public partial class Form1 : MetroForm
    {
        List<Celula> generic = new List<Celula>();
        Queue<No> nos = new Queue<No>();
        ListaHash[] listas;
        Fila fila;
        Lista lista;
        Pilha pilha;
        Hash_ hash;
        Arvore arvore;
        No no;
        BindingSource binding;
        Object valor;
        private bool realiza;
        public Form1()
        {
            InitializeComponent();
            fila = new Fila();
            lista = new Lista();
            arvore = new Arvore();
            no = new No();
            pilha = new Pilha();
            hash = new Hash_(10);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            valor = txtValor.Text;
            if (rbtFila.Checked)
                fila.Enfileira(valor);
            else if (rbtLista.Checked)
                lista.Insere(valor);
            else if (rbtArvore.Checked)
                arvore.Inserir(Convert.ToInt32(valor));
            else if (rbtPilha.Checked)
                pilha.empilha(Convert.ToInt32(valor));
            else if (rbtHash.Checked)
                hash.Insere(Convert.ToInt64(valor)); 
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (rbtFila.Checked)
            {
                dgvItens.DataSource = null;
                generic = fila.Imprime();
                foreach (var item in generic)
                {
                    if (item != null)
                    {
                        if (item.item == null)
                            dgvItens.Rows.Add(item.prx.item);
                        else if (item.prx != null)
                            dgvItens.Rows.Add(item.item);
                    }
                    else if (item != null && item.prx == null)
                        dgvItens.Rows.Add(item.item);
                }
            }
            else if (rbtLista.Checked)
            {
                dgvItens.DataSource = null;
                generic.Clear();
                generic = lista.Imprime();

                foreach (var item in generic)
                {
                    if (item != null)
                    {
                        if (item.item == null)
                            dgvItens.Rows.Add(item.prx.item);
                        else if (item.prx != null)
                            dgvItens.Rows.Add(item.item);
                        else if (item.prx == null)
                            dgvItens.Rows.Add(item.item);
                    }
                    else if (item != null && item.prx == null)
                        dgvItens.Rows.Add(item.item);
                }
            }
            else if (rbtArvore.Checked)
            {
                dgvItens.DataSource = null;
                generic.Clear();
                nos = arvore.Imprimir(arvore.Root);


                foreach (var item in nos)
                {
                    dgvItens.Rows.Add(item.getValor);
                }
            }
            else if (rbtPilha.Checked)
            {
                dgvItens.DataSource = null;
                generic.Clear();
                generic = pilha.Imprime();

                foreach (var item in generic)
                {
                    if (item != null)
                    {
                        if (item.item == null)
                            dgvItens.Rows.Add(item.prx.item);
                        else if (item.prx != null)
                            dgvItens.Rows.Add(item.item);
                        else if (item.prx == null)
                            dgvItens.Rows.Add(item.item);
                    }
                    else if (item != null && item.prx == null)
                        dgvItens.Rows.Add(item.item);
                }

            }
            else if (rbtHash.Checked)
            {
                long aux1;
                dgvItens.DataSource = null;
                generic.Clear();
                listas = hash.Imprime();
                for (long i = 0; i < listas.Length; i++)
                {
                    aux1 = hash.Pesquisa(i);
                    dgvItens.Rows.Add(aux1);
                }
            }
        }

        private void btnQtde_Click(object sender, EventArgs e)
        {
            int qtde;
            if (rbtFila.Checked)
            {
                qtde = fila.Quantidade();
                MessageBox.Show(Convert.ToString(qtde), "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbtLista.Checked)
            {
                qtde = lista.Quantidade();
                MessageBox.Show(Convert.ToString(qtde), "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbtArvore.Checked)
            {
                string qt = arvore.Quantidade;
                MessageBox.Show(qt, "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbtPilha.Checked)
            {
                qtde = pilha.tamanho();
                MessageBox.Show(Convert.ToString(qtde), "Quantidade ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
            else if (rbtHash.Checked)
            {
                qtde = hash.returnQtde();
                MessageBox.Show(Convert.ToString(qtde), "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
