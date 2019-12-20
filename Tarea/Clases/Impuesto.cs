using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Clases
{
    public class Impuesto
    {
        public Impuesto(string detalle, double porcentaje)
        {
            Detalle = detalle;
            Porcentaje = porcentaje;
        }

        private string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private double porcentaje;

       
        public double Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }

        public string Mostrar()
        {
            return "\n" + Detalle + " " + Porcentaje + "%";
        }

    }
}
