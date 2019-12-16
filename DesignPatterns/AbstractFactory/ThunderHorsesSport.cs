using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory {
    class ThunderHorsesSport : SportCar {
        public void ShowSportCar() {
            Console.WriteLine("\nModel: Thunder Horses Sport Car\n" +
                "Factory: Thunder Horses\nCategory: Sport");
        }
    }
}
