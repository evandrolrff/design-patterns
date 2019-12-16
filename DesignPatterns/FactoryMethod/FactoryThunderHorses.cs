using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod {
    class FactoryThunderHorses : FactoryCar {
        public Car CreateCar() {
            return new ThunderCar();
        }
    }
}
