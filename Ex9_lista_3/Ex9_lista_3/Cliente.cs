using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_lista_3
{
    class Cliente
    {
        private int qtdd;
        private const int MAX = 5;
        private string nome;
        private long cpf;
        private Animal[] animais;

        public Cliente()
        {
            animais = new Animal[MAX];
            qtdd = 0;
        }
        public void addAnimal(Animal a1)
        {
            animais[qtdd] = a1;
            qtdd++;
        }
        public void remoAnimal(Animal a1)
        {
            for(int i=0;i<qtdd;i++)
            {
                if(animais[i]==a1)
                {
                    for(int j=i;j<qtdd;j++)
                    {
                        animais[j] = animais[j + 1];
                    }
                    qtdd--;
                }
            }
        }
        public void list()
        {
            for(int i=0;i<qtdd;i++)
            {
                Console.WriteLine("Nome: " + animais[i].Nome);
                Console.WriteLine("Raça: " + animais[i].Raca + "\n");
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
