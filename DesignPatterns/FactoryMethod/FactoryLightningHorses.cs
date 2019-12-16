using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod {
    class FactoryLightningHorses : FactoryCar {
        public Car CreateCar() {
            return new LightningCar();
        }
    }
}
