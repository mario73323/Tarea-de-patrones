using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJERCICIO4.Interface;
namespace EJERCICIO4.Clases
{
    public class HP14CM0021LA : Inormalpc
    {
        public HP14CM0021LA() { }
        public string GetDetalleModel()
        {
            return "Model: HP-14-CM0021LA\nRAM: 4GB\nPorcesador: Intel PENTIUM \nGeneracio: 7ª Generacion\nDisco Duro: 1T\nTarjetaGrafica : NA\n";
        }
    }
}
