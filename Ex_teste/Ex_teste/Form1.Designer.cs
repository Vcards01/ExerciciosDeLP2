namespace Ex_teste
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTop = new System.Windows.Forms.Panel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.gpDados = new System.Windows.Forms.GroupBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.pBaixo = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnVizualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.CCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFunção = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTop.SuspendLayout();
            this.gpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.pBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTop.BackColor = System.Drawing.Color.AliceBlue;
            this.pTop.Controls.Add(this.txtPesquisar);
            this.pTop.Controls.Add(this.lbPesquisar);
            this.pTop.Location = new System.Drawing.Point(-1, -1);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(595, 66);
            this.pTop.TabIndex = 0;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(75, 25);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(491, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(13, 28);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lbPesquisar.TabIndex = 0;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // gpDados
            // 
            this.gpDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpDados.BackColor = System.Drawing.SystemColors.Control;
            this.gpDados.Controls.Add(this.dgvFuncionarios);
            this.gpDados.ForeColor = System.Drawing.Color.Black;
            this.gpDados.Location = new System.Drawing.Point(-1, 63);
            this.gpDados.Name = "gpDados";
            this.gpDados.Size = new System.Drawing.Size(595, 134);
            this.gpDados.TabIndex = 2;
            this.gpDados.TabStop = false;
            this.gpDados.Text = "Funcionarios";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCPF,
            this.CNome,
            this.CIdade,
            this.CSexo,
            this.CValor,
            this.cFunção});
            this.dgvFuncionarios.Location = new System.Drawing.Point(3, 16);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(589, 115);
            this.dgvFuncionarios.TabIndex = 0;
            // 
            // pBaixo
            // 
            this.pBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBaixo.BackColor = System.Drawing.Color.AliceBlue;
            this.pBaixo.Controls.Add(this.btnExcluir);
            this.pBaixo.Controls.Add(this.btnCalcular);
            this.pBaixo.Controls.Add(this.btnVizualizar);
            this.pBaixo.Controls.Add(this.button2);
            this.pBaixo.Controls.Add(this.btnNovo);
            this.pBaixo.Location = new System.Drawing.Point(-1, 195);
            this.pBaixo.Name = "pBaixo";
            this.pBaixo.Size = new System.Drawing.Size(595, 66);
            this.pBaixo.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExcluir.Location = new System.Drawing.Point(374, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Remover";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCalcular.Location = new System.Drawing.Point(210, 37);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(156, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular comissão";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnVizualizar
            // 
            this.btnVizualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnVizualizar.Location = new System.Drawing.Point(291, 8);
            this.btnVizualizar.Name = "btnVizualizar";
            this.btnVizualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVizualizar.TabIndex = 2;
            this.btnVizualizar.Text = "Visualizar";
            this.btnVizualizar.UseVisualStyleBackColor = true;
            this.btnVizualizar.Click += new System.EventHandler(this.btnVizualizar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.Location = new System.Drawing.Point(210, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNovo.Location = new System.Drawing.Point(129, 8);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // CCPF
            // 
            this.CCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCPF.HeaderText = "CPF";
            this.CCPF.Name = "CCPF";
            this.CCPF.ReadOnly = true;
            // 
            // CNome
            // 
            this.CNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNome.HeaderText = "Nome";
            this.CNome.Name = "CNome";
            this.CNome.ReadOnly = true;
            // 
            // CIdade
            // 
            this.CIdade.HeaderText = "Idade";
            this.CIdade.Name = "CIdade";
            this.CIdade.ReadOnly = true;
            // 
            // CSexo
            // 
            this.CSexo.HeaderText = "Sexo";
            this.CSexo.Name = "CSexo";
            this.CSexo.ReadOnly = true;
            // 
            // CValor
            // 
            this.CValor.HeaderText = "Valor Vendido";
            this.CValor.Name = "CValor";
            this.CValor.ReadOnly = true;
            // 
            // cFunção
            // 
            this.cFunção.HeaderText = "Função";
            this.cFunção.Name = "cFunção";
            this.cFunção.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.gpDados);
            this.Controls.Add(this.pBaixo);
            this.Controls.Add(this.pTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.gpDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.pBaixo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.GroupBox gpDados;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Panel pBaixo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnVizualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFunção;
    }
}

