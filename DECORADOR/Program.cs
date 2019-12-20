using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoradorAuto.Clases;

namespace DecoradorAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Automóvil ConfiguraciónPersonalizada = new Automóvil();

            Airbag AutoConAirbag = new Airbag(ConfiguraciónPersonalizada);
            GPS AutoConGPS = new GPS(AutoConAirbag);
            RadioTV AutoConRadioTV = new RadioTV(AutoConGPS);
            SensorRetro AutoConSensorRetro = new SensorRetro(AutoConRadioTV);

            Console.WriteLine("EL AUTOMÓVIL INCLUYE LOS SIGUIENTES ACCESORIOS Y FUNCIONABILIDADES:\n");

            Console.WriteLine(AutoConSensorRetro.obtenerDescripción());

            Console.ReadKey();



        }
    }
}
