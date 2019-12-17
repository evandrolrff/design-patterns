using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype {
    abstract class PrototypeCar {

        protected double buyCost;

        public abstract string Show();

        public abstract PrototypeCar clone();

        public double getBuyCost() {
            return buyCost;
        }

        public void setBuyCost(double cost) {
            buyCost = cost;
        }
    }
}
