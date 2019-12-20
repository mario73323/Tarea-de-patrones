using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2.Interface;
namespace Ejercicio2.Clases
{
    public class PCcLIENT
    {
        Inormalpc normal;
        Igamerpc gamer;


        public PCcLIENT(Ipc factory)
        {
            gamer = factory.GetIgamerpc();
            normal = factory.GetInormalpc();

        }
        public string GetgamerDetalleModel()
        {
            return gamer.GetDetalleModel();
        }
        public string GetnormalDetalleModel()

        {
            return normal.GetDetalleModel();

        }

    }
}