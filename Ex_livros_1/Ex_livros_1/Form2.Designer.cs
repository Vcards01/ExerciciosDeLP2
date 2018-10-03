namespace Ex_livros_1
{
    partial class Form2
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
            this.PaFiltrar = new System.Windows.Forms.Panel();
            this.TxtFiltrar = new System.Windows.Forms.TextBox();
            this.LBFiltrar = new System.Windows.Forms.Label();
            this.PaBotoes = new System.Windows.Forms.Panel();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.GrouBoxCentro = new System.Windows.Forms.GroupBox();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaFiltrar.SuspendLayout();
            this.PaBotoes.SuspendLayout();
            this.GrouBoxCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // PaFiltrar
            // 
            this.PaFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaFiltrar.BackColor = System.Drawing.SystemColors.Control;
            this.PaFiltrar.Controls.Add(this.TxtFiltrar);
            this.PaFiltrar.Controls.Add(this.LBFiltrar);
            this.PaFiltrar.Location = new System.Drawing.Point(2, 1);
            this.PaFiltrar.Name = "PaFiltrar";
            this.PaFiltrar.Size = new System.Drawing.Size(499, 61);
            this.PaFiltrar.TabIndex = 0;
            // 
            // TxtFiltrar
            // 
            this.TxtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFiltrar.Location = new System.Drawing.Point(60, 20);
            this.TxtFiltrar.Name = "TxtFiltrar";
            this.TxtFiltrar.Size = new System.Drawing.Size(391, 20);
            this.TxtFiltrar.TabIndex = 1;
            this.TxtFiltrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFiltrar_KeyDown);
            // 
            // LBFiltrar
            // 
            this.LBFiltrar.AutoSize = true;
            this.LBFiltrar.Location = new System.Drawing.Point(19, 23);
            this.LBFiltrar.Name = "LBFiltrar";
            this.LBFiltrar.Size = new System.Drawing.Size(35, 13);
            this.LBFiltrar.TabIndex = 0;
            this.LBFiltrar.Text = "Filtrar:";
            // 
            // PaBotoes
            // 
            this.PaBotoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PaBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.PaBotoes.Controls.Add(this.BtnRemover);
            this.PaBotoes.Controls.Add(this.BtnVisualizar);
            this.PaBotoes.Controls.Add(this.BtnEditar);
            this.PaBotoes.Controls.Add(this.BtnNovo);
            this.PaBotoes.Location = new System.Drawing.Point(2, 199);
            this.PaBotoes.Name = "PaBotoes";
            this.PaBotoes.Size = new System.Drawing.Size(499, 61);
            this.PaBotoes.TabIndex = 1;
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(345, 27);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(75, 23);
            this.BtnRemover.TabIndex = 3;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.Location = new System.Drawing.Point(264, 27);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnVisualizar.TabIndex = 2;
            this.BtnVisualizar.Text = "Visualizar";
            this.BtnVisualizar.UseVisualStyleBackColor = true;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(183, 27);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(102, 27);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // GrouBoxCentro
            // 
            this.GrouBoxCentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrouBoxCentro.Controls.Add(this.dgvLivros);
            this.GrouBoxCentro.Location = new System.Drawing.Point(2, 65);
            this.GrouBoxCentro.Name = "GrouBoxCentro";
            this.GrouBoxCentro.Size = new System.Drawing.Size(499, 138);
            this.GrouBoxCentro.TabIndex = 2;
            this.GrouBoxCentro.TabStop = false;
            this.GrouBoxCentro.Text = "Livros";
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CTitulo,
            this.CAutor});
            this.dgvLivros.Location = new System.Drawing.Point(3, 16);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.Size = new System.Drawing.Size(493, 119);
            this.dgvLivros.TabIndex = 0;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Codigo";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.ReadOnly = true;
            // 
            // CTitulo
            // 
            this.CTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CTitulo.HeaderText = "Titulo";
            this.CTitulo.Name = "CTitulo";
            this.CTitulo.ReadOnly = true;
            // 
            // CAutor
            // 
            this.CAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAutor.HeaderText = "Autor";
            this.CAutor.Name = "CAutor";
            this.CAutor.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.Controls.Add(this.GrouBoxCentro);
            this.Controls.Add(this.PaBotoes);
            this.Controls.Add(this.PaFiltrar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.PaFiltrar.ResumeLayout(false);
            this.PaFiltrar.PerformLayout();
            this.PaBotoes.ResumeLayout(false);
            this.GrouBoxCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaFiltrar;
        private System.Windows.Forms.Panel PaBotoes;
        private System.Windows.Forms.GroupBox GrouBoxCentro;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAutor;
        private System.Windows.Forms.TextBox TxtFiltrar;
        private System.Windows.Forms.Label LBFiltrar;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnVisualizar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
    }
}