using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Clases
{
    public sealed class Singletone
    {
        private static Singletone instancia = null;

        protected Singletone()
        {
        }

        private List<Impuesto> impuestos;
        public List<Impuesto> Impuestos

        {
            get { return impuestos; }
            set { impuestos = value; }
        }

        public static Singletone Instancia
        {
            get
            {
                if (instancia == null)
                {
                    Console.WriteLine("Se instancia");
                    instancia = new Singletone();
                }

                return instancia;
            }

        }
    }
}
