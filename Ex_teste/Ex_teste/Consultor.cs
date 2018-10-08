using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_teste
{
    public class Consultor : Funcionario
    {
        private double soma;
        private Dictionary<string, Funcionario> Revendedores = new Dictionary<string, Funcionario>();
        public Consultor(string cpf, string nome, int idade, string sexo,  double valorVendido) : base(cpf, nome, idade, sexo,valorVendido)
        {
        }

        public override double calculaComissao()
        {
           foreach(KeyValuePair<string,Funcionario> f in Revendedores)
            {
                soma = soma + f.Value.calculaComissao();
            }
            return ValorVendido * 0.3 + soma;
        }
        public void AddFuncionario(Funcionario f)
        {
            Revendedores.Add(f.Cpf, f);
        }
        public int NumSubordinados()
        {
            return Revendedores.Count;
        }
    }
}
