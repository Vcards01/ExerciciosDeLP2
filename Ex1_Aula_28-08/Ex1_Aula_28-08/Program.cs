using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Aula_28_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma;
            Figura[] figuras = new Figura[150];
            figuras[0] = new Circulo(0,0,1);
            figuras[1] = new Circulo(0, 0, 2);
            figuras[2] = new Circulo(0, 0, 3);
            figuras[3] = new Circulo(0, 0, 4);
            figuras[4] = new Circulo(0, 0, 5);
            figuras[5] = new Circulo(0, 0, 1);
            figuras[6] = new Circulo(0, 0, 1);
            figuras[7] = new Circulo(0, 0, 1);
            figuras[8] = new Circulo(0, 0, 1);
            figuras[9] = new Circulo(0, 0, 1);
            figuras[10] = new Circulo(0, 0, 1);
            figuras[11] = new Circulo(0, 0, 1);
            figuras[12] = new Circulo(0, 0, 1);
            figuras[13] = new Circulo(0, 0, 1);
            figuras[14] = new Circulo(0, 0, 1);
            figuras[15] = new Circulo(0, 0, 1);
            figuras[16] = new Circulo(0, 0, 1);
            figuras[17] = new Circulo(0, 0, 1);

            figuras[0] = new Circulo(0, 0, 1);
            figuras[0] = new Circulo(0, 0, 1);
            figuras[0] = new Circulo(0, 0, 1);
            figuras[0] = new Circulo(0, 0, 1);
            figuras[0] = new Circulo(0, 0, 1);

            Figura r1 = new Retangulo(0, 0, 1,1);
            Figura r2 = new Retangulo(0, 0, 2,2);
            Figura r3 = new Retangulo(0, 0, 3,3);
            Figura r4 = new Retangulo(0, 0, 4,4);
            Figura r5 = new Retangulo(0, 0, 5,5);
            Figura r6 = new Retangulo(0, 0, 6,6);
            Figura r7 = new Retangulo(0, 0, 7,7);
            Figura r8 = new Retangulo(0, 0, 8,8);
            Figura r9 = new Retangulo(0, 0, 9,9);
            Figura r10 = new Retangulo(0, 0, 10,10);
            Figura r11 = new Retangulo(0, 0, 11,11);
            Figura r12 = new Retangulo(0, 0, 12,12);
            Figura r13 = new Retangulo(0, 0, 13,13);
            Figura r14 = new Retangulo(0, 0, 14,14);
            Figura r15 = new Retangulo(0, 0, 15,15);
            Figura r16 = new Retangulo(0, 0, 16,16);
            Figura r17 = new Retangulo(0, 0, 17,17);
            Figura r18 = new Retangulo(0, 0, 18,18);
            Figura r19 = new Retangulo(0, 0, 19,19);
            Figura r20 = new Retangulo(0, 0, 20,20);
            Figura r21 = new Retangulo(0, 0, 21,21);
            Figura r22 = new Retangulo(0, 0, 22,22);
            Figura r23 = new Retangulo(0, 0, 23, 23);
            Figura r24 = new Retangulo(0, 0, 24, 24);
            Figura r25 = new Retangulo(0, 0, 25,25);
            Figura r26 = new Retangulo(0, 0, 26,26);
            Figura r27 = new Retangulo(0, 0, 27,27);
            Figura r28 = new Retangulo(0, 0, 28,28);
            Figura r29 = new Retangulo(0, 0, 29,29);
            Figura r30 = new Retangulo(0, 0, 30,30);
            Figura r31 = new Retangulo(0, 0, 31,31);
            Figura r32 = new Retangulo(0, 0, 32,32);
            Figura r33 = new Retangulo(0, 0, 33,33);
            Figura r34 = new Retangulo(0, 0, 34,34);
            Figura r35 = new Retangulo(0, 0, 35,35);
            Figura r36 = new Retangulo(0, 0, 36,36);
            Figura r37 = new Retangulo(0, 0, 37,36);
            Figura r38 = new Retangulo(0, 0, 38,38);
            Figura r39 = new Retangulo(0, 0, 39,39);
            Figura r40 = new Retangulo(0, 0, 40,40);
            Figura r41 = new Retangulo(0, 0, 41,41);
            Figura r42 = new Retangulo(0, 0, 42,42);
            Figura r43 = new Retangulo(0, 0, 43,43);
            Figura r44 = new Retangulo(0, 0, 44,44);
            Figura r45 = new Retangulo(0, 0, 45,45);
            Figura r46 = new Retangulo(0, 0, 46,46);
            Figura r47 = new Retangulo(0, 0, 47,47);
            Figura r48 = new Retangulo(0, 0, 48,48);
            Figura r49 = new Retangulo(0, 0, 49,49);
            Figura r50 = new Retangulo(0, 0, 50,50);

            Figura t1 = new Triangulo(0, 0, 1, 1);
            Figura t2 = new Triangulo(0, 0, 2, 2);
            Figura t3 = new Triangulo(0, 0, 3, 3);
            Figura t4 = new Triangulo(0, 0, 4, 4);
            Figura t5 = new Triangulo(0, 0, 5, 5);
            Figura t6 = new Triangulo(0, 0, 6, 6);
            Figura t7 = new Triangulo(0, 0, 7, 7);
            Figura t8 = new Triangulo(0, 0, 8, 8);
            Figura t9 = new Triangulo(0, 0, 9, 9);
            Figura t10 = new Triangulo(0, 0, 10, 10);
            Figura t11 = new Triangulo(0, 0, 11, 11);
            Figura t12 = new Triangulo(0, 0, 12, 12);
            Figura t13 = new Triangulo (0, 0, 13, 13);
            Figura t14 = new Triangulo(0, 0, 14, 14);
            Figura t15 = new Triangulo(0, 0, 15, 15);
            Figura t16 = new Triangulo(0, 0, 16, 16);
            Figura t17 = new Triangulo(0, 0, 17, 17);
            Figura t18 = new Triangulo(0, 0, 18, 18);
            Figura t19 = new Triangulo(0, 0, 19, 19);
            Figura t20 = new Triangulo(0, 0, 20, 20);
            Figura t21 = new Triangulo(0, 0, 21, 21);
            Figura t22 = new Triangulo (0, 0, 22, 22);
            Figura t23 = new Triangulo(0, 0, 23, 23);
            Figura t24 = new Triangulo(0, 0, 24, 24);
            Figura t25 = new Triangulo(0, 0, 25, 25);
            Figura t26 = new Triangulo(0, 0, 26, 26);
            Figura t27 = new Triangulo(0, 0, 27, 27);
            Figura t28 = new Triangulo(0, 0, 28, 28);
            Figura t29 = new Triangulo(0, 0, 29, 29);
            Figura t30 = new Triangulo(0, 0, 30, 30);
            Figura t31 = new Triangulo(0, 0, 31, 31);
            Figura t32 = new Triangulo(0, 0, 32, 32);
            Figura t33 = new Triangulo(0, 0, 33, 33);
            Figura t34 = new Triangulo(0, 0, 34, 34);
            Figura t35 = new Triangulo(0, 0, 35, 35);
            Figura t36 = new Triangulo(0, 0, 36, 36);
            Figura t37 = new Triangulo(0, 0, 37, 36);
            Figura t38 = new Triangulo(0, 0, 38, 38);
            Figura t39 = new Triangulo(0, 0, 39, 39);
            Figura t40 = new Triangulo(0, 0, 40, 40);
            Figura t41 = new Triangulo(0, 0, 41, 41);
            Figura t42 = new Triangulo(0, 0, 42, 42);
            Figura t43 = new Triangulo(0, 0, 43, 43);
            Figura t44 = new Triangulo(0, 0, 44, 44);
            Figura t45 = new Triangulo(0, 0, 45, 45);
            Figura t46 = new Triangulo(0, 0, 46, 46);
            Figura t47 = new Triangulo(0, 0, 47, 47);
            Figura t48 = new Triangulo(0, 0, 48, 48);
            Figura t49 = new Triangulo(0, 0, 49, 49);
            Figura t50 = new Triangulo(0, 0, 50, 50);

            foreach(Figura c in )
        }

    }
}
