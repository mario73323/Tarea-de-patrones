using DecoradorAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4.Clases
{
    public class Mouseinalambrico : DecoradorPc
    {
        public Mouseinalambrico(Idecorador laptop) : base(laptop)
        {
        }

        public override string obtenerDescripción()
        {
            return this.laptop.obtenerDescripción() + "-Mouse Inalambrico\n";
        }
    }
}
