using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    internal class Program {
        static void Main(string[] args) {

            Engine engine = new Engine(7.0, 40.0);



            Console.WriteLine(Engine.convertToLP100(32));
        }
    }
}
