using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJERCICIO4.Interface;

namespace EJERCICIO4.Clases
{
    public class DELLXPS6360 : Igamerpc
    {
        public DELLXPS6360() { }
        public string GetDetalleModel()
        {
            return "Model: DELL XPS9360\nRAM: 8GB\nPorcesador: Intel I7 \nGeneracio: 8ª Generacion\nDisco Duro: 1T\nTarjetaGrafica : Nvidia 2080 TI\n";

        }
    }
}
