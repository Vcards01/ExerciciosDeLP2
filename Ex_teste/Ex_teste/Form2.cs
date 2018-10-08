using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_teste
{
    public partial class Form2 : Form
    {
        private Funcionario funcionario;
        private bool editavel;
        private bool salvar = true;
        private string visualizar;
        private string sex;
        public Form2()
        {
            InitializeComponent();
            cbFunção.SelectedIndex = 0;
        }
        public Form2(bool editavel, Funcionario f)
        {

            this.editavel = editavel;
            salvar = false;
            this.funcionario = f;
            InitializeComponent();

            txtCpf.Text = f.Cpf;
            txtNome.Text = f.Nome;
            txtIdade.Text = f.Idade.ToString();
            txtValor.Text = f.ValorVendido.ToString();
            if (f.Sexo == "Masculino")
            {
                rbtMasculino.Checked = true;
            }
            else
            {
                rbtFeminino.Checked = true;
            }
            if (f is Consultor)
            {
                cbFunção.SelectedIndex = 1;
            }
            else if (f is Revendedor)
            {
                cbFunção.SelectedIndex = 0;
            }


        }
        public Form2(string v, Funcionario f)
        {
            visualizar = v;
            salvar = false;
            InitializeComponent();
            txtCpf.Text = f.Cpf;
            txtNome.Text = f.Nome;
            txtIdade.Text = f.Idade.ToString();
            txtValor.Text = f.ValorVendido.ToString();
            txtCpf.ReadOnly = true;
            txtIdade.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtValor.ReadOnly = true;
            if (f.Sexo == "Masculino")
            {
                rbtMasculino.Checked = true;

            }
            else
            {
                rbtFeminino.Checked = true;
            }
            rbtMasculino.Enabled = false;
            rbtFeminino.Enabled = false;
            if (f is Consultor)
            {
                cbFunção.SelectedIndex = 1;
            }
            else if (f is Revendedor)
            {
                cbFunção.SelectedIndex = 0;
            }
            cbFunção.Enabled = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtMasculino.Checked)
            {
                sex = "Masculino";
            }
            if (rbtFeminino.Checked)
            {
                sex = "Feminino";
            }
            if (salvar)
            {
                IDataBase bd = new BDdicionario();
                
                if (txtResp.Text != "")
                {
                    if (((BDdicionario)bd).verifica(txtResp.Text))
                        {
                        if (cbFunção.Text == "Revendedor")
                        {
                            bd.Create(new Revendedor(txtCpf.Text, txtNome.Text, int.Parse(txtIdade.Text), sex, double.Parse(txtValor.Text)));
                        }
                        else if (cbFunção.Text == "Consultor")
                        {
                            bd.Create(new Consultor(txtCpf.Text, txtNome.Text, int.Parse(txtIdade.Text), sex, double.Parse(txtValor.Text)));
                        }
                        foreach (Funcionario f in bd.ListAll())
                        {
                            if (f == bd.Read(txtResp.Text))
                            {
                                if (f is Consultor)
                                {
                                    ((Consultor)f).AddFuncionario(bd.Read(txtCpf.Text));
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Responsavel não encontrado", "CPF responsavel invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (cbFunção.Text == "Revendedor")
                    {
                        bd.Create(new Revendedor(txtCpf.Text, txtNome.Text, int.Parse(txtIdade.Text), sex, double.Parse(txtValor.Text)));
                    }
                    else if (cbFunção.Text == "Consultor")
                    {
                        bd.Create(new Consultor(txtCpf.Text, txtNome.Text, int.Parse(txtIdade.Text), sex, double.Parse(txtValor.Text)));
                    }
                }
            }
            if (editavel)
            {
                IDataBase bd = new BDdicionario();
                if (cbFunção.Text == "Revendedor")
                {
                    bd.Update(new Revendedor(txtCpf.Text, txtNome.Text, int.Parse(txtIdade.Text), sex, double.Parse(txtValor.Text)));
                }
                else if (cbFunção.Text == "Consultor")
                {
                    bd.Update(new Consultor(txtCpf.Text, txtNome.Text, int.Parse(txtIdade.Text), sex, double.Parse(txtValor.Text)));
                }
                
            }

            Dispose();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
    }

