using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoradorAuto.Interfaces;
namespace DecoradorAuto.Clases
{
    public class Airbag : DecoradorAutomóvil
    {
        public Airbag(IAutomóvil automóvil) : base(automóvil)
        {
        }

        public override string obtenerDescripción()
        {
            return this.automóvil.obtenerDescripción() + "- Airbag\n";
        }
    }
}
