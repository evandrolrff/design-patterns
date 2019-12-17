using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder {
    class Client {

        public Client() {
            DealershipDirector dealership = new DealershipDirector(new ThunderHorsesBuilder());

            dealership.constructCar();
            ProductCar car = dealership.getCar();
            Console.WriteLine(car.toString());

            dealership = new DealershipDirector(new RayHorsesBuilder());
            dealership.constructCar();
            car = dealership.getCar();
            Console.WriteLine(car.toString());
        }
    }
}
