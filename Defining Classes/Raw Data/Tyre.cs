using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    class Tyre
    {
        public double TirePressure { get; set; } 
        public int TireYear { get; set; }

        public Tyre(double pressure, int year)
        {
            this.TirePressure = pressure;
            this.TireYear = year ;
        }
    }
}
