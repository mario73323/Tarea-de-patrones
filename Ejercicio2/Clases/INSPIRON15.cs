using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2.Interface;
namespace Ejercicio2.Clases
{
    public class INSPIRON15 : Inormalpc
    {
        public INSPIRON15() { }
        public string GetDetalleModel()
        {
            return "Model: DELL INSPIRON 15.6\nRAM: 4GB\nPorcesador: Intel Celeron \nGeneracio: 8ª Generacion\nDisco Duro: 1T\nTarjetaGrafica : NA\n";
        }
    }
}
