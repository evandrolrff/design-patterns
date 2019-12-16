using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod {
    class FactoryRayHorses : FactoryCar {
        public Car CreateCar() {
            return new RayCar();
        }
    }
}
