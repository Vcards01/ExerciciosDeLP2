namespace Ex_livros_1
{
    public class Livro
    {
        private long codigo;
        private string titulo;
        private string autor;

        public Livro(long codigo,string titulo,string autor)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
        }

        public long Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }
    }
}