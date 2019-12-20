using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoradorAuto.Interfaces;

namespace DecoradorAuto.Clases
{
    public class Automóvil : IAutomóvil

    {
        public Automóvil()
        {
        }

        public string obtenerDescripción()
        {
            return "- Luces Amarillas\n- Tapacubos Cromados\n- Llave Control Extra\n" +
                "- Alfombras\n- Tapizado en Negro\n";
        }
    }
}
