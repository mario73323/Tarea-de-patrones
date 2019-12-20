using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2.Clases;
using Ejercicio2.Interface;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipc laptopsdell = new DELL();
            PCcLIENT laptopdellcliente = new PCcLIENT(laptopsdell);
            Console.WriteLine("----------FABRICA DE COMPUTADORAS  EL PROCESADOR----------");


            Console.WriteLine("----------LAPTOP DELL----------");
            Console.WriteLine(laptopdellcliente.GetgamerDetalleModel());
            Console.WriteLine(laptopdellcliente.GetnormalDetalleModel());


            Ipc laptopshp = new HP();
            PCcLIENT laptopshpcliente = new PCcLIENT(laptopshp);
            Console.WriteLine("----------LAPTOP HP----------");
            Console.WriteLine(laptopshpcliente.GetgamerDetalleModel());
            Console.WriteLine(laptopshpcliente.GetnormalDetalleModel());

            Console.ReadKey();


        }
    }
}