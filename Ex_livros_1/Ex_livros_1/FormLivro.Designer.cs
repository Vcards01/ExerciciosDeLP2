namespace Ex_livros_1
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
            this.LBTitulo = new System.Windows.Forms.Label();
            this.LBAutor = new System.Windows.Forms.Label();
            this.LBNumero = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Location = new System.Drawing.Point(42, 27);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(36, 13);
            this.LBTitulo.TabIndex = 0;
            this.LBTitulo.Text = "Titulo:";
            // 
            // LBAutor
            // 
            this.LBAutor.AutoSize = true;
            this.LBAutor.Location = new System.Drawing.Point(42, 68);
            this.LBAutor.Name = "LBAutor";
            this.LBAutor.Size = new System.Drawing.Size(35, 13);
            this.LBAutor.TabIndex = 1;
            this.LBAutor.Text = "Autor:";
            // 
            // LBNumero
            // 
            this.LBNumero.AutoSize = true;
            this.LBNumero.Location = new System.Drawing.Point(304, 68);
            this.LBNumero.Name = "LBNumero";
            this.LBNumero.Size = new System.Drawing.Size(43, 13);
            this.LBNumero.TabIndex = 2;
            this.LBNumero.Text = "Codigo:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(84, 27);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(366, 20);
            this.TxtTitulo.TabIndex = 3;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(84, 68);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(191, 20);
            this.TxtAutor.TabIndex = 4;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(358, 65);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(92, 20);
            this.TxtNumero.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(374, 113);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 113);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 148);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.LBNumero);
            this.Controls.Add(this.LBAutor);
            this.Controls.Add(this.LBTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.Label LBAutor;
        private System.Windows.Forms.Label LBNumero;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

