using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_livros_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            Fill("");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(dgvLivros.CurrentCell!=null)
            {
                int row = dgvLivros.CurrentCell.RowIndex;
                IDataBase bd = new BDDicionario();
                Livro result = bd.Read(long.Parse(dgvLivros.Rows[row].Cells[0].Value.ToString()));
                Form1 form = new Form1(true, result);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                Fill("");
            }
            
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (dgvLivros.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Deseja realmente remover?", "Remoção de livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result==DialogResult.Yes)
                {
                    int row = dgvLivros.CurrentCell.RowIndex;
                    IDataBase bd = new BDDicionario();
                    bd.Delete(long.Parse(dgvLivros.Rows[row].Cells[0].Value.ToString()));
                    Fill("");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione uma linha para remover", "Nenhuma linha selecionada",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }           
        }
        private void Fill(string filtro)
        {
            IDataBase bd = new BDDicionario();
            List<Livro> list = bd.ListAll();

            dgvLivros.Rows.Clear();
            foreach(Livro l in list)
            {
                if(filtro ==""||l.Autor.ToUpper().Contains(filtro.ToUpper())||l.Titulo.ToUpper().Contains(filtro.ToUpper()))
                    {
                    dgvLivros.Rows.Add(l.Codigo, l.Titulo, l.Autor);
                }
                
            }
        }

       
        private void TxtFiltrar_KeyDown(object sender, KeyEventArgs e)
        {
            Fill(TxtFiltrar.Text);
        }
    }
}
