using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoradorAuto.Interfaces;
using EJERCICIO4.Interface;

namespace EJERCICIO4.Clases
{
    public class PCcLIENT: Idecorador
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

        public string obtenerDescripción()
        {
            return "";
        }
    }
}