using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_teste
{
    public class Revendedor : Funcionario
    {
        public Revendedor(string cpf, string nome, int idade, string sexo, double valorVendido) : base(cpf, nome, idade, sexo, valorVendido)
        {
        }

        public override double calculaComissao()
        {
            return ValorVendido * 0.15;
        }
    }
}
