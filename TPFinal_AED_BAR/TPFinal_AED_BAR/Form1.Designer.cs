namespace TPFinal_AED_BAR
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtFila = new System.Windows.Forms.RadioButton();
            this.rbtPilha = new System.Windows.Forms.RadioButton();
            this.rbtLista = new System.Windows.Forms.RadioButton();
            this.rbtArvore = new System.Windows.Forms.RadioButton();
            this.rbtHash = new System.Windows.Forms.RadioButton();
            this.btnInserir = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnListar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnQtde = new Syncfusion.Windows.Forms.ButtonAdv();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estruturas AED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(85, 72);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(131, 20);
            this.txtValor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione a Estrutura:";
            // 
            // rbtFila
            // 
            this.rbtFila.AutoSize = true;
            this.rbtFila.Location = new System.Drawing.Point(42, 159);
            this.rbtFila.Name = "rbtFila";
            this.rbtFila.Size = new System.Drawing.Size(41, 17);
            this.rbtFila.TabIndex = 5;
            this.rbtFila.TabStop = true;
            this.rbtFila.Text = "Fila";
            this.rbtFila.UseVisualStyleBackColor = true;
            // 
            // rbtPilha
            // 
            this.rbtPilha.AutoSize = true;
            this.rbtPilha.Location = new System.Drawing.Point(160, 159);
            this.rbtPilha.Name = "rbtPilha";
            this.rbtPilha.Size = new System.Drawing.Size(48, 17);
            this.rbtPilha.TabIndex = 6;
            this.rbtPilha.TabStop = true;
            this.rbtPilha.Text = "Pilha";
            this.rbtPilha.UseVisualStyleBackColor = true;
            // 
            // rbtLista
            // 
            this.rbtLista.AutoSize = true;
            this.rbtLista.Location = new System.Drawing.Point(42, 191);
            this.rbtLista.Name = "rbtLista";
            this.rbtLista.Size = new System.Drawing.Size(47, 17);
            this.rbtLista.TabIndex = 7;
            this.rbtLista.TabStop = true;
            this.rbtLista.Text = "Lista";
            this.rbtLista.UseVisualStyleBackColor = true;
            // 
            // rbtArvore
            // 
            this.rbtArvore.AutoSize = true;
            this.rbtArvore.Location = new System.Drawing.Point(160, 191);
            this.rbtArvore.Name = "rbtArvore";
            this.rbtArvore.Size = new System.Drawing.Size(56, 17);
            this.rbtArvore.TabIndex = 8;
            this.rbtArvore.TabStop = true;
            this.rbtArvore.Text = "Árvore";
            this.rbtArvore.UseVisualStyleBackColor = true;
            // 
            // rbtHash
            // 
            this.rbtHash.AutoSize = true;
            this.rbtHash.Location = new System.Drawing.Point(42, 219);
            this.rbtHash.Name = "rbtHash";
            this.rbtHash.Size = new System.Drawing.Size(50, 17);
            this.rbtHash.TabIndex = 9;
            this.rbtHash.TabStop = true;
            this.rbtHash.Text = "Hash";
            this.rbtHash.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(13, 268);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(94, 268);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnQtde
            // 
            this.btnQtde.Location = new System.Drawing.Point(175, 268);
            this.btnQtde.Name = "btnQtde";
            this.btnQtde.Size = new System.Drawing.Size(75, 23);
            this.btnQtde.TabIndex = 12;
            this.btnQtde.Text = "Quantidade";
            this.btnQtde.Click += new System.EventHandler(this.btnQtde_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId});
            this.dgvItens.Location = new System.Drawing.Point(277, 12);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(240, 279);
            this.dgvItens.TabIndex = 13;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Item";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.SteelBlue;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(529, 298);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.btnQtde);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.rbtHash);
            this.Controls.Add(this.rbtArvore);
            this.Controls.Add(this.rbtLista);
            this.Controls.Add(this.rbtPilha);
            this.Controls.Add(this.rbtFila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.PaleGreen;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estruturas AED";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtFila;
        private System.Windows.Forms.RadioButton rbtPilha;
        private System.Windows.Forms.RadioButton rbtLista;
        private System.Windows.Forms.RadioButton rbtArvore;
        private System.Windows.Forms.RadioButton rbtHash;
        private Syncfusion.Windows.Forms.ButtonAdv btnInserir;
        private Syncfusion.Windows.Forms.ButtonAdv btnListar;
        private Syncfusion.Windows.Forms.ButtonAdv btnQtde;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
    }
}

