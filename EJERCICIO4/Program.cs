using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJERCICIO4.Clases;
using EJERCICIO4.Interface;

namespace EJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipc laptopsdell = new DELL();
            PCcLIENT laptopdellcliente = new PCcLIENT(laptopsdell);
            ParlanteBluetho laptopconparlante = new ParlanteBluetho(laptopdellcliente);
            Mouseinalambrico laptopconmouse = new Mouseinalambrico(laptopdellcliente);

            Console.WriteLine("----------FABRICA DE COMPUTADORAS  EL PROCESADOR----------");


            Console.WriteLine("----------COMPRA LAPTOP DELL----------");
            Console.WriteLine(laptopdellcliente.GetgamerDetalleModel());
            Console.WriteLine("La computadora tiene los siguientes accesorios:\n");

            Console.WriteLine(laptopconmouse.obtenerDescripción());

            Console.ReadKey();
      
        }
    }
}