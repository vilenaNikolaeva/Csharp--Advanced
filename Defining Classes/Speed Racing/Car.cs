using System.Collections.Generic;

namespace Speed_Racing
{
    class Car
    {
        private string model;
        private double fuelAmound;
        private double fuelCosumtion;
        private double travelDistane;

        public string Model { get; set; }
        public double FuelAmound { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public int TravelDistance { get; set; }
        public List<Car> CarsModels { get; set; }
        public Car Fast { get; internal set; }

       
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmound = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TravelDistance = 0;
        }
      
        public bool Drive(int distance)
        {
            var neededFuel = distance * this.FuelConsumptionPerKilometer;
            if (neededFuel <= this.FuelAmound)
            {
                this.FuelAmound -= neededFuel;

                this.TravelDistance += distance;
                return true;
            }

            return false;
        }
        public override string ToString()

        {
            return $"{this.Model} {this.FuelAmound:F2} {this.TravelDistance}";
        }
    }
}
