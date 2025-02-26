﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    public class FuelStation : FuelInfo
    {
        public string StationName { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }

        public override string ToString()
        {
            return $"Заправочная станция: {StationName}, {Address}, {ContactInfo}";
        }
    }
}

