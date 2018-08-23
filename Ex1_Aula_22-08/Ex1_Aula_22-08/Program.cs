using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Aula_22_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            a1.Nome = "Gato";
            a1.Apelido = "Pingo";
            a1.Selvagem = true;
            a1.Dono = p1;
            a2.Nome = "Cachorro";
            a2.Apelido = "Nina";
            a2.Selvagem = false;
            a2.Dono = p1;
            a3.Nome = "Coelho";
            a3.Apelido = "Fofinho";
            a3.Selvagem = false;
            a3.Dono = p1;
            a4.Nome = "Galinha";
            a4.Apelido = "Pintadinha";
            a4.Selvagem = true;
            a4.Dono = p1;
            a5.Nome = "Tartaruga";
            a5.Apelido = "Tuck";
            a5.Selvagem = false;
            a5.Dono = p1;
            p1.Add(a1);
            p1.Add(a3);
            p1.Add(a2);
            p1.Add(a5);
            p1.Add(a4);


        }
    }
}
