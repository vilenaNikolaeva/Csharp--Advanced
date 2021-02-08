using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Constructor
{
    class Car
    {

        private string make;
        private string model;
        private int year;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            bool canDrive = this.FuelQuantity - (distance * this.FuelConsumption) >= 0;

            if (canDrive)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                throw new IndexOutOfRangeException($"Not enough fuel to perform this trip!");
            }
        }
        public string Details()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.Append($"Fuel:{this.FuelQuantity:f2}");
            return result.ToString();
        }
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make, string model, int year):this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;
        }
        public Car(string make, string model, int year, double fuelQuantity,
            double fuelConsumption?
           
        {
           
        }
    }
}
