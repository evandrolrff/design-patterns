using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype {
    class RayFlashCarPrototype : PrototypeCar {

        public RayFlashCarPrototype() {
            buyCost = 0.0;
        }

        public RayFlashCarPrototype(RayFlashCarPrototype car) {
            buyCost = car.buyCost;
        }

        public override PrototypeCar clone() {
            return new RayFlashCarPrototype(this);
        }

        public override string Show() {
            return string.Format("Model: Ray Flash\tAutomaker: Ray Horses\tCost: {0}", getBuyCost());
        }
    }
}
