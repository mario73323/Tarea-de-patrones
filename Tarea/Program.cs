using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Clases;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Impuesto iva = new Impuesto("Iva",12);
            Impuesto ice = new Impuesto("ICE", 15);

            Singletone.Instancia.Impuestos = new List<Impuesto>();
            Singletone.Instancia.Impuestos.Add(iva);
            Singletone.Instancia.Impuestos.Add(ice);

            foreach ( Impuesto item in Singletone.Instancia.Impuestos)
            {
                Console.WriteLine(item.Mostrar());
            }
            

            Console.ReadKey();

        }
    }
}
