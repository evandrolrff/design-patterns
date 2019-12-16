using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory {
    class ThunderHorsesNormal : NormalCar {
        public void ShowNormalCar() {
            Console.WriteLine("\nModel: Thunder Horses Normal Car\n" +
                "Factory: Thunder Horses\nCategory: Normal");
        }
    }
}
