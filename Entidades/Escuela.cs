using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10_12WPF.Entidades
{
    class Escuela
    {
        public int Matricula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Curso { get; set; }

        public Escuela(int Matricula, String Mombre, String Apellido, String Curso)
        {
            this.Matricula = Matricula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Curso = Curso;
        }
    }
}
