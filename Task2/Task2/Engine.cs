using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    internal class Engine {

        private readonly double tankCapacity, displacement;
        private const double defaultTankCapacity = 50.0;
        private double fuelAmount;

        public Engine(double displacement, double fuelAmount, double tankCapacity = defaultTankCapacity) {
            this.displacement = displacement;
            this.tankCapacity = tankCapacity;
            if (fuelAmount > tankCapacity) throw new ArgumentException("Amount of fuel > tank capacity!");
            this.fuelAmount = fuelAmount;
        }

        public static double convertToMpg(double lper100) {
            return (235.214583 / lper100);
        }

        public static double convertToLP100(double milesPerGallon) {
            return (235.214583 / milesPerGallon);
        }

        public void Work(double km) {
            double fuelConsumed = this.displacement * 4 * km / 100;
            if (fuelConsumed > fuelAmount) throw new ArgumentException("Not enough fuel to drive for " + km + " km !");
            fuelAmount -= fuelConsumed;
        }
    }
}