using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory {
    class RayHorsesSport : SportCar {
        public void ShowSportCar() {
            Console.WriteLine("\nModel: Ray Horses Sport Car\n" +
                "Factory: Ray Horses\nCategory: Sport");
        }
    }
}
