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
    
    public partial class Form1 : Form
    {
        private bool editavel = true;
        private bool salvar = true;
        private Livro livro;
        private BDDicionario bd;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(bool editavel, Livro l)
        {
            this.editavel = editavel;
            salvar = false;
            this.livro = l;
            InitializeComponent();
            TxtAutor.Text = l.Autor;
            TxtNumero.Text = l.Codigo.ToString();
            TxtTitulo.Text = l.Titulo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(salvar)
            {
                IDataBase bd = new BDDicionario();
                bd.Save(new Livro(0, TxtTitulo.Text, TxtAutor.Text));
                Dispose();
            }
            else if(editavel)
            {
                IDataBase bd = new BDDicionario();
                bd.Update(new Livro(long.Parse(TxtNumero.Text), TxtTitulo.Text, TxtAutor.Text));
                Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
