using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_petshop
{
    class Cachorro
    {
        private string nome;
        private string raca;
        private bool vacinado;

        public Cachorro(string nome, string raca, bool vacinado)
        {
            Nome = nome;
            Raca = raca;
            Vacinado = vacinado;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Raca
        {
            get
            {
                return raca;
            }

            set
            {
                raca = value;
            }
        }

        public bool Vacinado
        {
            get
            {
                return vacinado;
            }

            set
            {
                vacinado = value;
            }
        }
    }
}
