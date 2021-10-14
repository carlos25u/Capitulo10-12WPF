using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10_12WPF.Entidades
{
    class Tienda
    {
        public int Codigo { get; set; }
        public String Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Double Precio { get; set; }

        public Tienda(int codigo, string Descripcion, int Cantidad, double Precio)
        {
            this.Codigo = codigo;
            this.Descripcion = Descripcion;
            this.Cantidad = Cantidad;
        }
    }
}
