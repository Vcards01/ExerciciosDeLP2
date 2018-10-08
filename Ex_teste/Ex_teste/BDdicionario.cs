using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_teste
{

    public class BDdicionario : IDataBase
    {
        static private Dictionary<string, Funcionario> funcionarios = new Dictionary<string, Funcionario>();

        public void Create(Funcionario f)
        {
            funcionarios.Add(f.Cpf, f);
        }

        public void Delete(string cpf)
        {
            funcionarios.Remove(cpf);
        }

        public List<Funcionario> ListAll()
        {
            return funcionarios.Values.ToList<Funcionario>();
        }

        public Funcionario Read(string cpf)
        {
            return funcionarios[cpf];
        }

        public void Update(Funcionario f)
        {
            funcionarios[f.Cpf] = f;
        }
        public bool verifica(string cpfResp)
        {
            if(funcionarios.ContainsKey(cpfResp))
            {
                return true;
            }
            return false;
        }
    }
}
