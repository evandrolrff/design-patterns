using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory {
    class FactoryThunderHorses : CarFactory {
        public NormalCar CreateNormalCar() {
            return new ThunderHorsesNormal();
        }

        public SportCar CreateSportCar() {
            return new ThunderHorsesSport();
        }
    }
}
