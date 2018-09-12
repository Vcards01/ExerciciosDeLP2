using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_petshop
{
    class Petshop
    {
        Dictionary<long, Pessoa> Cliente = new Dictionary<long, Pessoa>();

        public void AddPessoa(Pessoa p)
        {
            Cliente.Add(p.Cpf, p);
        }
        public void AddCachorro(long cpf, Cachorro c)
        {
            if(Cliente.ContainsKey(cpf))
            {
                Cliente[cpf].AddCachorro(c);
            }
        }
        public void List()
        {
            foreach (KeyValuePair<long, Pessoa> c in Cliente) 
                Console.WriteLine(c);
        }
        public void ListDog(long cpf,Cachorro c)
        {
            if(Cliente.ContainsKey(cpf))
            {
                Cliente[cpf].ListarCachorro();
            }
        }
        public void RmvPessoa(long cpf)
        {
            if(Cliente.ContainsKey(cpf))
            {
                Cliente.Remove(cpf);
            }
        }
        public void RmvDog(long cpf,string nome)
        {
            if(Cliente.ContainsKey(cpf))
            {
                Cliente[cpf].RmvCachorro(nome);
            }
        }
        public void ListarVacinados(bool vacina)
        {
            if(vacina==true)
            {
                for(int i=0;i<Cliente.Count();i++)
                {
                    Cliente[i].ListVacina();
                }
            }
            else
            {
                for (int i = 0; i < Cliente.Count(); i++)
                {
                    Cliente[i].ListVacina();
                }
            }
        }
        public void ListarVacinados(bool vacina,long cpf)
        {
            if (Cliente.ContainsKey(cpf))
            {
                if(vacina==true)
                {
                    Cliente[cpf].ListVacina();
                }
                else
                {
                    Cliente[cpf].ListVacina();
                }
                
            }
        }
    }
}
