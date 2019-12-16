using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod {
    class Client {

        public Client() {
            FactoryCar factory = new FactoryRayHorses();
            Car car = factory.CreateCar();
            car.ShowInfo();

            factory = new FactoryThunderHorses();
            car = factory.CreateCar();
            car.ShowInfo();

            factory = new FactoryLightningHorses();
            car = factory.CreateCar();
            car.ShowInfo();
        }
    }
}
