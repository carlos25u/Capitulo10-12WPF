using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10_12WPF.Entidades
{
    class Poligono
    {
        public int ladoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }
        public int LadoD { get; set; }
        public int LadoE { get; set; }

        public Poligono(int LadoA, int LadoB, int LadoC, int LadoD, int LadoE)
        {
            this.ladoA = ladoA;
            this.LadoB = LadoB;
            this.LadoC = LadoC;
            this.LadoD = LadoD;
            this.LadoE = LadoE;
        }

        public Poligono(int LadoA, int LadoB, int LadoC)
        {
            this.ladoA = ladoA;
            this.LadoB = LadoB;
            this.LadoC = LadoC;
        }

        public String ValoresValido(int a, int b, int c)
        {
            if(a <= 0)
            {
                return "El lado A no puede ser menor a 0";
            }
            if (b <= 0)
            {
                return "El lado B no puede ser menor a 0";
            }
            if (c <= 0)
            {
                return "El lado B no puede ser menor a 0";
            }
            return "";
        }

        public override string ToString()
        {
            int resultado = ladoA + LadoB + LadoC;

            return resultado.ToString();
        }
    }
}
