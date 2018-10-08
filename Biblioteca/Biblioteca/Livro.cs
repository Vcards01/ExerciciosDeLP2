namespace Biblioteca
{
    public class Livro
    {
        private long codigo;
        private string titulo;
        private string autor;

        
        public Livro(long codigo, string titulo, string autor)
        {
            this.Codigo = codigo;
            this.Titulo = titulo;
            this.Autor = autor;
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