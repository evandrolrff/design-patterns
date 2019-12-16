using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod {
    class LightningCar : Car {
        public void ShowInfo() {
            Console.WriteLine("\nModel: Lightning car\nFactory: Lightning Horses");
        }
    }
}
