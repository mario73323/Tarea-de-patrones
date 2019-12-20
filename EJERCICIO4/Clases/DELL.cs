using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJERCICIO4.Interface;

namespace EJERCICIO4.Clases
{
    public class DELL : Ipc
    {
        public DELL()
        {
        }


        public Igamerpc GetIgamerpc()
        {
            return new DELLXPS6360();
        }

        public Inormalpc GetInormalpc()
        {
            return new INSPIRON15();
        }
    }
}
