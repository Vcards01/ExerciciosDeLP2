using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Aula_28_08
{
    class Circulo:Figura
    {
        double raio;

        public Circulo():base(0,0)
        {

        }
        public Circulo(int x, int y,double raio) : base(x, y)
        {
            Raio = raio;
        }
        public override double Area()
        {
            return Math.PI*Math.Pow(raio,2);
        }
        public override string ToString()
        {
            return base.ToString()+" Diametro:" +Diametro;
        }
        public double Diametro
        {
            get
            {
                return raio*2;
            }

        }

        public double Raio
        {
            get
            {
                return raio;
            }

            set
            {
                raio = value;
            }
        }
    }
}
