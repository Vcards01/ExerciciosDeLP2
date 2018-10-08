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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            fill("");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.CurrentCell != null)
            {
                int row = dgvFuncionarios.CurrentCell.RowIndex;
                IDataBase bd = new BDdicionario();
                Funcionario result = bd.Read(dgvFuncionarios.Rows[row].Cells[0].Value.ToString());
                Form2 form = new Form2(true, result);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                fill("");
            }
        }
        private void fill(string filtro)
        {
            IDataBase bd = new BDdicionario();
            List<Funcionario> list = bd.ListAll();
            dgvFuncionarios.Rows.Clear();
            foreach(Funcionario f in list)
            {
                if(filtro==""||f.Cpf.Contains(filtro)||f.Nome.ToUpper().Contains(filtro))
                {
                    dgvFuncionarios.Rows.Add(f.Cpf, f.Nome, f.Idade, f.Sexo, f.ValorVendido);
                }
            }
        }

        private void btnVizualizar_Click(object sender, EventArgs e)
        {
            int row = dgvFuncionarios.CurrentCell.RowIndex;
            IDataBase bd = new BDdicionario();
            Funcionario result = bd.Read(dgvFuncionarios.Rows[row].Cells[0].Value.ToString());
            Form2 form = new Form2("visu", result);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            fill("");
        }
    }
}
