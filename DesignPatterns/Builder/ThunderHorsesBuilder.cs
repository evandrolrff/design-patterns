using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder {
    class ThunderHorsesBuilder : BuilderCar {
        public override void builtAutomaker() {
            car.automaker = "Thunder Horses";
        }

        public override void builtCost() {
            car.cost = 10000.00;
        }

        public override void builtDetailMotor() {
            car.motorDetail = "1.6";
        }

        public override void builtFactoryYear() {
            car.facotryYear = 2016;
        }

        public override void builtModel() {
            car.model = "Thunder storm";
        }
    }
}
