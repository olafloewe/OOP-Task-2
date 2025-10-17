using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    internal class Program {
        static void Main(string[] args) {

            Engine engine = new Engine(7.0, 50);
            Car car = new Car("BMW", "M5", new Engine(5.0,60,60));

            car.Go(40);

            Console.WriteLine(engine);
        }
    }
}