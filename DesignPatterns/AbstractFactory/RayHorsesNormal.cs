using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory {
    class RayHorsesNormal : NormalCar {
        public void ShowNormalCar() {
            Console.WriteLine("\nModel: Ray Horses Normal Car\n" +
                "Factory: Ray Horses\nCategory: Normal");
        }
    }
}
