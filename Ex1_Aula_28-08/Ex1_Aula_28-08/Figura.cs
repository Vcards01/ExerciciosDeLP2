using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Aula_28_08
{
    abstract class Figura
    {
        private int x;
        private int y;


        public Figura(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return "[" + x + "," + y + "]";
        }
        public abstract double Area();
             
        
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }
}
