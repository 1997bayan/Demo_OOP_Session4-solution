﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session4.Interfaces
{
    internal class SeriesByTwo : Iseries
    {
        public int current { get ; set ; }

        public void GetNext()
        {
            current += 2;
        }
    }
}
