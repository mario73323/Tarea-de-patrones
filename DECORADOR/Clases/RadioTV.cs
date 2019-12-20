using DecoradorAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoradorAuto.Clases
{
    class RadioTV : DecoradorAutomóvil

    {
        public RadioTV(IAutomóvil automóvil) : base(automóvil)
        {
        }

        public override string obtenerDescripción()
        {
            return this.automóvil.obtenerDescripción() + "- Radio con TV\n";
        }
    }
}
