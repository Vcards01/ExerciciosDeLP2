using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormPainel : Form
    {
        public FormPainel()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormLivro form = new FormLivro();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            Fill("");
        }

        private void Fill(string filtro)
        {
            IDataBase bd = new BDDicionario();
            List<Livro> list = bd.ListAll();

            dgvLivros.Rows.Clear();
            foreach (Livro l in list)
            {
                if (filtro == "" || l.Autor.ToUpper().Contains(filtro.ToUpper()) || l.Titulo.ToUpper().Contains(filtro.ToUpper()))
                {
                    dgvLivros.Rows.Add(l.Codigo, l.Titulo, l.Autor);
                }

            }
        }
    }
}
