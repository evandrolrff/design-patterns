using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder {
    abstract class BuilderCar {

        protected ProductCar car = new ProductCar();

        public abstract void builtCost();

        public abstract void builtDetailMotor();

        public abstract void builtFactoryYear();

        public abstract void builtModel();

        public abstract void builtAutomaker();

        public ProductCar getCar() {
            return car;
        }

    }
}
