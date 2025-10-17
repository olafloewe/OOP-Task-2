using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_2 {
    internal class Car {

        private Engine engine;
        private readonly string make, model;

        public Car(string make, string model, Engine engine) {
            this.make = make;
            this.model = model;
            this.engine = engine;
        }
        public Car(string make, string model, double displacement, double fuelVolume) {
            this.make = make;
            this.model = model;
            this.engine = new Engine(displacement, fuelVolume);
        }
        public Car(string make, string model, double displacement, double fuelVolume, double tankCapacity) {
            this.make = make;
            this.model = model;
            this.engine = new Engine(displacement, fuelVolume, tankCapacity);
        }

        public void Go(double km) {
            Console.WriteLine("The car is going " + km + " kilometers.");
            Thread.Sleep((int)(100 * km));
            
            try {
                engine.Work(km);
                Console.WriteLine("Here I am!");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}