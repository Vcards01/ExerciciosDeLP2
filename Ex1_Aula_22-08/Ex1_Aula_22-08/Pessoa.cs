using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Aula_22_08
{
    class Pessoa
    {
        private int qtdd = 0;
        private const int MAX = 10;
        private string nome;
        private int idade;
        private long identidade;
        private string profissao;
        private Animal[] pet = new Animal[MAX];

       
        public String Falar()
        {
            return (nome + " esta falando");
        }
        public void Trabalhar(int horas)
        {
            Console.Write(nome + "esta trabalhando a" + horas + " horas");
        }
        public void Comer()
        {
            Console.Write(nome + " esta comendo");
        }
        public void Add(Animal a)
        {
            if(qtdd<MAX)
            {
                pet[qtdd] = a;
                qtdd++;
            }
            else
            {
                Console.Write("Sem espaço disponivel");
            }
        }
        public void Remove(Animal a)
        {
            for(int i=0;i<qtdd;i++)
            {
                if(pet[i]==a)
                {
                    for(int j=i;j<qtdd;j++)
                    {
                        pet[j] = pet[j + 1];
                    }
                    qtdd--;
                    break;
                }
            }
        }
        public void SizeOf()
        {
            for(int i=0;i<qtdd;i++)
            {
                Console.WriteLine(pet[i].Apelido);
            }
        }
        public void gets(int ind)
        {
            for(int i=0;i<qtdd;i++)
            {
                if(i==ind)
                {
                    Console.WriteLine(pet[i].Apelido);
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
        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = (value>=0)?value:0;
            }
        }
        public long Identidade
        {
            get
            {
                return identidade;
            }

            set
            {
                identidade = (value>0)?value:0000;
            }
        }
        public string Profissao
        {
            get
            {
                return profissao;
            }

            set
            {
                profissao = value;
            }
        }


    }
}
