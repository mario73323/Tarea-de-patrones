using DecoradorAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4.Clases
{
    public class ParlanteBluetho : DecoradorPc
    {
        public ParlanteBluetho(Idecorador laptop) : base(laptop)
        {
        }

        public override string obtenerDescripción()
        {
            return this.laptop.obtenerDescripción() + "-Parlante Bluethoot\n";
        }
    }
}
