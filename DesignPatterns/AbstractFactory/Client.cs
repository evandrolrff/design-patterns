using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory {
    class Client {

        public Client() {
            CarFactory factory = new FactoryRayHorses();
            SportCar sportCar = factory.CreateSportCar();
            NormalCar normalCar = factory.CreateNormalCar();

            sportCar.ShowSportCar();
            normalCar.ShowNormalCar();

            factory = new FactoryThunderHorses();
            sportCar = factory.CreateSportCar();
            normalCar = factory.CreateNormalCar();

            sportCar.ShowSportCar();
            normalCar.ShowNormalCar();
        }
    }
}
