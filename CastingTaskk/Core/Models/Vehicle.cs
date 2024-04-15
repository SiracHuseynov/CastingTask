﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public abstract class Vehicle
    {

        public string Marka { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public abstract void ShowInfo();


    }
}
