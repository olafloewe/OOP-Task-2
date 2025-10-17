using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    internal class Program {
        static void Main(string[] args) {

            // read make and model
            Console.Write("Make: ");
            string make = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();

            // read engine parameters
            double displacement = ReadDouble("Displacement in L: ",1);
            double tankCapacity = ReadDouble("Tank Capacity in L: ",1);
            double fuelVolume = ReadDouble("Fuel Volume in L: ", 0,tankCapacity);
 
            Car car = new Car(make, model, new Engine(displacement,fuelVolume,tankCapacity));


            if (car != null) {
                bool exit = false;
                while (!exit) {
                    Console.Clear();
                    Console.WriteLine(car.GetName());
                    Console.WriteLine(car.GetFuelAmount());

                    Console.WriteLine($"[D]rive\n[R]efuel\n[Q]uit");
                    switch (Console.ReadKey(true).Key) {

                        case ConsoleKey.D:
                            try { 
                                car.Go(ReadDouble("Enter distance to travel [km]: ", 1)); 
                            } catch (Exception ex) { 
                                Console.WriteLine(ex.Message);
                            }
                            Console.ReadKey(true);
                            break;
                        case ConsoleKey.R:
                            try {
                                car.Refuel(ReadDouble("Enter amount of fuel to refuel [L]: ", 0));
                            } catch (Exception ex) {
                                Console.WriteLine(ex.Message);
                            }
                            Console.ReadKey(true);
                            break;
                        case ConsoleKey.Q:
                            exit = true;
                            break;
                    }
                }
            }
        }

        static double ReadDouble(string prompt, double min = double.MinValue, double max = double.MaxValue) {
            double value;

            do {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                double.TryParse(input, out value);
            } while(value < min || value > max);
            return value;
        }
    }
}