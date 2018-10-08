namespace Ex_teste
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbValorVendido = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.lbfunção = new System.Windows.Forms.Label();
            this.cbFunção = new System.Windows.Forms.ComboBox();
            this.lbResp = new System.Windows.Forms.Label();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(40, 35);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(40, 87);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(30, 13);
            this.lbCPF.TabIndex = 1;
            this.lbCPF.Text = "CPF:";
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(40, 144);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(37, 13);
            this.lbIdade.TabIndex = 2;
            this.lbIdade.Text = "Idade:";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(336, 144);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(34, 13);
            this.lbSexo.TabIndex = 3;
            this.lbSexo.Text = "Sexo:";
            // 
            // lbValorVendido
            // 
            this.lbValorVendido.AutoSize = true;
            this.lbValorVendido.Location = new System.Drawing.Point(40, 192);
            this.lbValorVendido.Name = "lbValorVendido";
            this.lbValorVendido.Size = new System.Drawing.Size(76, 13);
            this.lbValorVendido.TabIndex = 4;
            this.lbValorVendido.Text = "Valor Vendido:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(451, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(81, 80);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(161, 20);
            this.txtCpf.TabIndex = 6;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(76, 141);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(58, 20);
            this.txtIdade.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(122, 189);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(186, 20);
            this.txtValor.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtFeminino);
            this.panel1.Controls.Add(this.rbtMasculino);
            this.panel1.Location = new System.Drawing.Point(376, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 23);
            this.panel1.TabIndex = 13;
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(82, 3);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtFeminino.TabIndex = 1;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(3, 3);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // lbfunção
            // 
            this.lbfunção.AutoSize = true;
            this.lbfunção.Location = new System.Drawing.Point(140, 144);
            this.lbfunção.Name = "lbfunção";
            this.lbfunção.Size = new System.Drawing.Size(46, 13);
            this.lbfunção.TabIndex = 14;
            this.lbfunção.Text = "Função:";
            // 
            // cbFunção
            // 
            this.cbFunção.FormattingEnabled = true;
            this.cbFunção.Items.AddRange(new object[] {
            "Revendedor",
            "Consultor"});
            this.cbFunção.Location = new System.Drawing.Point(192, 140);
            this.cbFunção.Name = "cbFunção";
            this.cbFunção.Size = new System.Drawing.Size(116, 21);
            this.cbFunção.TabIndex = 15;
            // 
            // lbResp
            // 
            this.lbResp.AutoSize = true;
            this.lbResp.Location = new System.Drawing.Point(275, 83);
            this.lbResp.Name = "lbResp";
            this.lbResp.Size = new System.Drawing.Size(95, 13);
            this.lbResp.TabIndex = 16;
            this.lbResp.Text = "CPF Responsavel:";
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(371, 80);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(161, 20);
            this.txtResp.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 261);
            this.Controls.Add(this.txtResp);
            this.Controls.Add(this.lbResp);
            this.Controls.Add(this.cbFunção);
            this.Controls.Add(this.lbfunção);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbValorVendido);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbNome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbValorVendido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.Label lbfunção;
        private System.Windows.Forms.ComboBox cbFunção;
        private System.Windows.Forms.Label lbResp;
        private System.Windows.Forms.TextBox txtResp;
    }
}