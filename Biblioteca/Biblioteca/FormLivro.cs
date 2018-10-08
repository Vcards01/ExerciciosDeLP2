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
    public partial class FormLivro : Form
    {
        private bool editavel=true;
        private bool salvar=true;
        private Livro livro;
        private BDDicionario bd;
        public FormLivro()
        {
            InitializeComponent();
        }
        public FormLivro(bool editavel,Livro livro)
        {
            this.editavel = editavel;
            salvar = false;
            this.livro = livro;
            InitializeComponent();
            txtAutor.Text = livro.Autor;
            txtCodigo.Text = livro.Codigo.ToString();
            txtTitulo.Text = livro.Titulo;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (salvar)
            {
                IDataBase bd = new BDDicionario();
                bd.save(new Livro(0, txtTitulo.Text,txtAutor.Text));
                Dispose();
            }
        }
    }
}
