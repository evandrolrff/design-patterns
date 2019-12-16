using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod {
    class RayCar : Car {
        public void ShowInfo() {
            Console.WriteLine("\nModel: Ray car\nFactory: Ray Horses");
        }
    }
}
