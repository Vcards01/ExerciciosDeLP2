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
            p1.Add(a1);
            p1.Add(a2);
            p1.SizeOf();
            p1.gets(1);
            p1.Remove(a1);
            p1.gets(1);
            p1.SizeOf();
            a5.Nome = "Dinossauro";
            a5.Apelido = "Pingado";
            a5.Selvagem = true;
            a5.Dono = p1;
            p1.Add(a5);
            p1.gets(1);
            Console.Read();

        }
    }
}
