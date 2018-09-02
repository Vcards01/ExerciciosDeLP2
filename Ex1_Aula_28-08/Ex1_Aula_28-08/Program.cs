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
            
            Figura[] figuras = new Figura[150];
            figuras[0] = new Circulo(0,0,1);
            figuras[1] = new Circulo(0, 0, 2);
            figuras[2] = new Circulo(0, 0, 3);
            figuras[3] = new Circulo(0, 0, 4);
            figuras[4] = new Circulo(0, 0, 5);
            figuras[5] = new Circulo(0, 0, 6);
            figuras[6] = new Circulo(0, 0, 7);
            figuras[7] = new Circulo(0, 0, 8);
            figuras[8] = new Circulo(0, 0, 9);
            figuras[9] = new Circulo(0, 0, 10);
            figuras[10] = new Circulo(0, 0, 11);
            figuras[11] = new Circulo(0, 0, 12);
            figuras[12] = new Circulo(0, 0, 13);
            figuras[13] = new Circulo(0, 0, 14);
            figuras[14] = new Circulo(0, 0, 15);
            figuras[15] = new Circulo(0, 0, 16);
            figuras[16] = new Circulo(0, 0, 17);
            figuras[17] = new Circulo(0, 0, 18);
            figuras[18] = new Circulo(0, 0, 19);
            figuras[19] = new Circulo(0, 0, 20);
            figuras[20] = new Circulo(0, 0, 21);
            figuras[21] = new Circulo(0, 0, 22);
            figuras[22] = new Circulo(0, 0, 23);
            figuras[23] = new Circulo(0, 0, 24);
            figuras[24] = new Circulo(0, 0, 25);
            figuras[25] = new Circulo(0, 0, 26);
            figuras[26] = new Circulo(0, 0, 27);
            figuras[27] = new Circulo(0, 0, 28);
            figuras[28] = new Circulo(0, 0, 29);
            figuras[29] = new Circulo(0, 0, 30);
            figuras[30] = new Circulo(0, 0, 31);
            figuras[31] = new Circulo(0, 0, 32);
            figuras[32] = new Circulo(0, 0, 33);
            figuras[33] = new Circulo(0, 0, 34);
            figuras[34] = new Circulo(0, 0, 35);
            figuras[35] = new Circulo(0, 0, 36);
            figuras[36] = new Circulo(0, 0, 37);
            figuras[37] = new Circulo(0, 0, 38);
            figuras[38] = new Circulo(0, 0, 39);
            figuras[39] = new Circulo(0, 0, 40);
            figuras[40] = new Circulo(0, 0, 41);
            figuras[41] = new Circulo(0, 0, 42);
            figuras[42] = new Circulo(0, 0, 43);
            figuras[43] = new Circulo(0, 0, 44);
            figuras[44] = new Circulo(0, 0, 45);
            figuras[45] = new Circulo(0, 0, 46);
            figuras[46] = new Circulo(0, 0, 47);
            figuras[47] = new Circulo(0, 0, 48);
            figuras[48] = new Circulo(0, 0, 49);
            figuras[49] = new Circulo(0, 0, 50);


            figuras[50] = new Retangulo (0, 0, 1,1);
            figuras[51] = new Retangulo(0, 0, 2,2);
            figuras[52] = new Retangulo(0, 0, 3,3);
            figuras[53] = new Retangulo(0, 0, 4,4);
            figuras[54] = new Retangulo(0, 0, 5,5);
            figuras[55] = new Retangulo(0, 0, 6,6);
            figuras[56] = new Retangulo(0, 0, 7,7);
            figuras[57] = new Retangulo(0, 0, 8,8);
            figuras[58] = new Retangulo(0, 0, 9,9);
            figuras[59] = new Retangulo(0, 0, 10,10);
            figuras[60] = new Retangulo(0, 0, 11,11);
            figuras[61] = new Retangulo(0, 0, 12,12);
            figuras[62] = new Retangulo(0, 0, 13,13);
            figuras[63] = new Retangulo(0, 0, 14,14);
            figuras[64] = new Retangulo(0, 0, 15,15);
            figuras[65] = new Retangulo(0, 0, 16,16);
            figuras[66] = new Retangulo(0, 0, 17,17);
            figuras[67] = new Retangulo(0, 0, 18,18);
            figuras[68] = new Retangulo(0, 0, 19,19);
            figuras[69] = new Retangulo(0, 0, 20,20);
            figuras[70] = new Retangulo(0, 0, 21,21);
            figuras[71] = new Retangulo(0, 0, 22,22);
            figuras[72] = new Retangulo(0, 0, 23,23);
            figuras[73] = new Retangulo(0, 0, 24,24);
            figuras[74] = new Retangulo(0, 0, 25,25);
            figuras[75] = new Retangulo(0, 0, 26,26);
            figuras[76] = new Retangulo(0, 0, 27,27);
            figuras[77] = new Retangulo(0, 0, 28,28);
            figuras[78] = new Retangulo(0, 0, 29,29);
            figuras[79] = new Retangulo(0, 0, 30,30);
            figuras[80] = new Retangulo(0, 0, 31,31);
            figuras[81] = new Retangulo(0, 0, 32,32);
            figuras[82] = new Retangulo(0, 0, 33,33);
            figuras[83] = new Retangulo(0, 0, 34,34);
            figuras[84] = new Retangulo(0, 0, 35,35);
            figuras[85] = new Retangulo(0, 0, 36,36);
            figuras[86] = new Retangulo(0, 0, 37,37);
            figuras[87] = new Retangulo(0, 0, 38,38);
            figuras[88] = new Retangulo(0, 0, 39,39);
            figuras[89] = new Retangulo(0, 0, 40,40);
            figuras[90] = new Retangulo(0, 0, 41,41);
            figuras[91] = new Retangulo(0, 0, 42,42);
            figuras[92] = new Retangulo(0, 0, 43,43);
            figuras[93] = new Retangulo(0, 0, 44,44);
            figuras[94] = new Retangulo(0, 0, 45,45);
            figuras[95] = new Retangulo(0, 0, 46,46);
            figuras[96] = new Retangulo(0, 0, 47,47);
            figuras[97] = new Retangulo(0, 0, 48,48);
            figuras[98] = new Retangulo(0, 0, 49,49);
            figuras[99] = new Retangulo(0, 0, 50,50);

            figuras[100] = new Triangulo (0, 0, 1, 1);
            figuras[101] = new Triangulo(0, 0, 2, 2);
            figuras[102] = new Triangulo(0, 0, 3, 3);
            figuras[103] = new Triangulo(0, 0, 4, 4);
            figuras[104] = new Triangulo(0, 0, 5, 5);
            figuras[105] = new Triangulo(0, 0, 6, 6);
            figuras[106] = new Triangulo(0, 0, 7, 7);
            figuras[107] = new Triangulo(0, 0, 8, 8);
            figuras[108] = new Triangulo(0, 0, 9, 9);
            figuras[109] = new Triangulo(0, 0, 10, 10);
            figuras[110] = new Triangulo(0, 0, 11, 11);
            figuras[111] = new Triangulo(0, 0, 12, 12);
            figuras[112] = new Triangulo(0, 0, 13, 13);
            figuras[113] = new Triangulo(0, 0, 14, 14);
            figuras[114] = new Triangulo(0, 0, 15, 15);
            figuras[115] = new Triangulo(0, 0, 16, 16);
            figuras[116] = new Triangulo(0, 0, 17, 17);
            figuras[117] = new Triangulo(0, 0, 18, 18);
            figuras[118] = new Triangulo(0, 0, 19, 19);
            figuras[119] = new Triangulo(0, 0, 20, 20);
            figuras[120] = new Triangulo(0, 0, 21, 21);
            figuras[121] = new Triangulo(0, 0, 22, 22);
            figuras[122] = new Triangulo(0, 0, 23, 23);
            figuras[123] = new Triangulo(0, 0, 24, 24);
            figuras[124] = new Triangulo(0, 0, 25, 25);
            figuras[125] = new Triangulo(0, 0, 26, 26);
            figuras[126] = new Triangulo(0, 0, 27, 27);
            figuras[127] = new Triangulo(0, 0, 28, 28);
            figuras[128] = new Triangulo(0, 0, 29, 29);
            figuras[129] = new Triangulo(0, 0, 30, 30);
            figuras[130] = new Triangulo(0, 0, 31, 31);
            figuras[131] = new Triangulo(0, 0, 32, 32);
            figuras[132] = new Triangulo(0, 0, 33, 33);
            figuras[133] = new Triangulo(0, 0, 34, 34);
            figuras[134] = new Triangulo(0, 0, 35, 35);
            figuras[135] = new Triangulo(0, 0, 36, 36);
            figuras[136] = new Triangulo(0, 0, 37, 37);
            figuras[137] = new Triangulo(0, 0, 38, 38);
            figuras[138] = new Triangulo(0, 0, 39, 39);
            figuras[139] = new Triangulo(0, 0, 40, 40);
            figuras[140] = new Triangulo(0, 0, 41, 41);
            figuras[141] = new Triangulo(0, 0, 42, 42);
            figuras[142] = new Triangulo(0, 0, 43, 43);
            figuras[143] = new Triangulo(0, 0, 44, 44);
            figuras[144] = new Triangulo(0, 0, 45, 45);
            figuras[145] = new Triangulo(0, 0, 46, 46);
            figuras[146] = new Triangulo(0, 0, 47, 47);
            figuras[147] = new Triangulo(0, 0, 48, 48);
            figuras[148] = new Triangulo(0, 0, 49, 49);
            figuras[149] = new Triangulo(0, 0, 50, 50);

            foreach (Figura c in figuras)
            {
                double soma = c.Area();
                soma=soma+soma
                   }
        }

    }
}
