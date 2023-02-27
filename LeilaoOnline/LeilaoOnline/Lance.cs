using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoOnline
{
    public class Lance
    {
        public Interessado Interessado { get; set; }
        public double Valor { get; set; }

        public Lance()
        {

        }
        public Lance(Interessado interessado, double lance)
        {
            this.Interessado = interessado;
            this.Valor = lance;
        }
    }
}
