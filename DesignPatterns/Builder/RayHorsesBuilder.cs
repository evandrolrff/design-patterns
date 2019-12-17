using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder {
    class RayHorsesBuilder : BuilderCar {
        public override void builtAutomaker() {
            car.automaker = "Ray Horses";
        }

        public override void builtCost() {
            car.cost = 12000.00;
        }

        public override void builtDetailMotor() {
            car.motorDetail = "1.8";
        }

        public override void builtFactoryYear() {
            car.facotryYear = 2017;
        }

        public override void builtModel() {
            car.model = "Ray flash";
        }
    }
}
