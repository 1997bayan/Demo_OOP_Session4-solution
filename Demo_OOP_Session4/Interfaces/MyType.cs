﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session4.Interfaces
{
    internal class MyType : IMyType // Implement 
    {
        public int Id { get; set ; }

        public void MyFun(int x)
        {
            Console.WriteLine($"Hello Route :  X = {x} , Id = {Id}");
        }

    }
}
