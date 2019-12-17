using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder {
    class ProductCar {
        public double cost;
        public string motorDetail;
        public int facotryYear;
        public string model;
        public string automaker;

        public string toString() {
            return string.Format("Car: {0}\tAutomaker: {1}\tYear: {2}\tMotor: {3}\tCost: {4}", model, automaker, facotryYear, motorDetail, cost);
        }
    }
}
