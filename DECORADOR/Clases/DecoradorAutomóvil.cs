using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoradorAuto.Clases;
using DecoradorAuto.Interfaces;

namespace DecoradorAuto.Clases
{
    public abstract class DecoradorAutomóvil : IAutomóvil
    {
        protected IAutomóvil automóvil;

        public DecoradorAutomóvil(IAutomóvil automóvil) { this.automóvil = automóvil; }

        public abstract string obtenerDescripción();


    }
}
