using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2.Interface;
namespace Ejercicio2.Clases
{
        public class HP14CM1024LA : Igamerpc
        {
            public HP14CM1024LA() { }
            public string GetDetalleModel()
            {
                return "Model: HP-14-CM1024LA\nRAM: 8GB\nPorcesador: Intel I7 \nGeneracio: 8ª Generacion\nDisco Duro: 1T\nTarjetaGrafica : Nvidia 2080 TI\n";
            }
        }
    }
