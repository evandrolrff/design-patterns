using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder {
    class DealershipDirector {
        
        protected BuilderCar automaker;

        public DealershipDirector(BuilderCar automake) {
            automaker = automake;
        }

        public void constructCar() {
            automaker.builtCost();
            automaker.builtFactoryYear();
            automaker.builtDetailMotor();
            automaker.builtModel();
            automaker.builtAutomaker();
        }

        public ProductCar getCar() {
            return automaker.getCar();
        }
    }
}
