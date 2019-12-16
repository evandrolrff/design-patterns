using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod {
    class ThunderCar : Car {
        public void ShowInfo() {
            Console.WriteLine("\nModel: Thunder car\nFactory: Thunder Horses");
        }
    }
}
