﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2.Interface;

namespace Ejercicio2.Clases
{
    public class HP : Ipc
    {
        public Igamerpc GetIgamerpc()
        {
            return new HP14CM1024LA();
        }

        public Inormalpc GetInormalpc()
        {
            return new HP14CM0021LA();
        }
    }
}
