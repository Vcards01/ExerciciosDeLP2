namespace Biblioteca
{
    partial class FormPainel
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.pnlBaixo = new System.Windows.Forms.Panel();
            this.gpbLivro = new System.Windows.Forms.GroupBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopo.SuspendLayout();
            this.pnlBaixo.SuspendLayout();
            this.gpbLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopo.Controls.Add(this.txtFiltrar);
            this.pnlTopo.Controls.Add(this.lbFiltrar);
            this.pnlTopo.Location = new System.Drawing.Point(0, 1);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(530, 71);
            this.pnlTopo.TabIndex = 0;
            // 
            // pnlBaixo
            // 
            this.pnlBaixo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlBaixo.Controls.Add(this.btnRemover);
            this.pnlBaixo.Controls.Add(this.btnVisualizar);
            this.pnlBaixo.Controls.Add(this.btnEditar);
            this.pnlBaixo.Controls.Add(this.btnNovo);
            this.pnlBaixo.Location = new System.Drawing.Point(0, 190);
            this.pnlBaixo.Name = "pnlBaixo";
            this.pnlBaixo.Size = new System.Drawing.Size(530, 71);
            this.pnlBaixo.TabIndex = 1;
            // 
            // gpbLivro
            // 
            this.gpbLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbLivro.Controls.Add(this.dgvLivros);
            this.gpbLivro.Location = new System.Drawing.Point(0, 73);
            this.gpbLivro.Name = "gpbLivro";
            this.gpbLivro.Size = new System.Drawing.Size(530, 117);
            this.gpbLivro.TabIndex = 2;
            this.gpbLivro.TabStop = false;
            this.gpbLivro.Text = "Livros";
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(12, 24);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lbFiltrar.TabIndex = 0;
            this.lbFiltrar.Text = "Filtrar";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Location = new System.Drawing.Point(50, 21);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(413, 20);
            this.txtFiltrar.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(106, 36);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(187, 36);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(268, 36);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(349, 36);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cTitulo,
            this.cAutor});
            this.dgvLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLivros.Location = new System.Drawing.Point(3, 16);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.Size = new System.Drawing.Size(524, 98);
            this.dgvLivros.TabIndex = 0;
            // 
            // cCodigo
            // 
            this.cCodigo.HeaderText = "Codigo";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            // 
            // cTitulo
            // 
            this.cTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTitulo.HeaderText = "Titulo";
            this.cTitulo.Name = "cTitulo";
            this.cTitulo.ReadOnly = true;
            // 
            // cAutor
            // 
            this.cAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAutor.HeaderText = "Autor";
            this.cAutor.Name = "cAutor";
            this.cAutor.ReadOnly = true;
            // 
            // FormPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.gpbLivro);
            this.Controls.Add(this.pnlBaixo);
            this.Controls.Add(this.pnlTopo);
            this.Name = "FormPainel";
            this.Text = "FormPainel";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlBaixo.ResumeLayout(false);
            this.gpbLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.Panel pnlBaixo;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpbLivro;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAutor;
    }
}