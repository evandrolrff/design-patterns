using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype {
    class ThunderStormCarPrototype : PrototypeCar {

        public ThunderStormCarPrototype(ThunderStormCarPrototype carPrototype) {
            buyCost = carPrototype.buyCost;
        }

        public ThunderStormCarPrototype() {
            buyCost = 0.0;
        }

        public override PrototypeCar clone() {
            return new ThunderStormCarPrototype(this);
        }

        public override string Show() {
            return string.Format("Model: Thunder Storm\tAutomaker: Thunder Horses\tCost: {0}", getBuyCost());
        }
    }
}
