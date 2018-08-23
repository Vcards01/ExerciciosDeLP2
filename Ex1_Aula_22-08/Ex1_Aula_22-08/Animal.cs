using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Aula_22_08
{
    class Animal
    {
        private string nome;
        private string apelido;
        private bool selvagem;
        private Pessoa dono;

      
        public String Comunicar()
        {
            return nome + "esta comunicando(som caracteristico do animal)";
        }
        public void Brincar()
        {
            Console.Write(nome + " esta brincando");
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
        public string Apelido
        {
            get
            {
                return apelido;
            }

            set
            {
                apelido = value;
            }
        }
        public bool Selvagem
        {
            get
            {
                return selvagem;
            }

            set
            {
                selvagem = value;
            }
        }
        public Pessoa Dono
        {
            get
            {
                return dono;
            }

            set
            {
                dono = value;
            }
        }
    }
}
