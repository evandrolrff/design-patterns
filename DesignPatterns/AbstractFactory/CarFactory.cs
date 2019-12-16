using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory {
    interface CarFactory {
        NormalCar CreateNormalCar();
        SportCar CreateSportCar();
    }
}
