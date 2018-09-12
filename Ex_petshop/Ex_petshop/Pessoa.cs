using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_petshop
{
    class Pessoa
    {
        private string nome;
        private long cpf;
        private List<Cachorro> pets;

        public Pessoa(string nome, long cpf, List<Cachorro> pets)
        {
            Nome = nome;
            Cpf = cpf;
            pets = new List<Cachorro>();
        }
        public void AddCachorro( Cachorro c)
        {
            pets.Add(c);
        }
        public void ListarCachorro()
        {
            foreach(Cachorro c in pets )
            {
                Console.WriteLine(c.Nome);
            }
        }
        public void RmvCachorro(string nome)
        {
            foreach(Cachorro c in pets)
            {
                if (c.Nome == nome)
                {
                    pets.Remove(c);
                }
            }
        }
        public void ListVacina()
        {
            foreach (Cachorro c in pets)
            {
                if ( c.Vacinado==true)
                {
                    Console.WriteLine(c.Nome+" esta vacinado");
                }
                else
                {
                    Console.WriteLine(c.Nome + " não esta vacinado");
                }
            }
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

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

       
    }
}
