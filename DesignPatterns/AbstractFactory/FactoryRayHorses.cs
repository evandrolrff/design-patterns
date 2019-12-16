using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory {
    class FactoryRayHorses : CarFactory {
        public NormalCar CreateNormalCar() {
            return new RayHorsesNormal();
        }

        public SportCar CreateSportCar() {
            return new RayHorsesSport();
        }
    }
}
