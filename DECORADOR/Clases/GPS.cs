using DecoradorAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoradorAuto.Clases
{
    public class GPS : DecoradorAutomóvil
    {
        public GPS(IAutomóvil automóvil) : base(automóvil)
        {
        }

        public override string obtenerDescripción()
        {
            return this.automóvil.obtenerDescripción() + "- GPS\n";
        }
    }
}
