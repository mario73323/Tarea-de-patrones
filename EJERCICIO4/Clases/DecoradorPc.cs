using DecoradorAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4.Clases
{
    public abstract class DecoradorPc: Idecorador
    {
        protected Idecorador laptop;

        public DecoradorPc(Idecorador laptop) { this.laptop = laptop; }

        public abstract string obtenerDescripción();

    }
}
