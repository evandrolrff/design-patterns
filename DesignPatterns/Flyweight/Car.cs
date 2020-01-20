using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight {
    class Car {
        public string Owner { get; set; }

        public string Number { get; set; }

        public string Company { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string toString() {
            return string.Format("[Owner: {0}, Number: {1}, Company: {2}, Model: {3}, Color: {4}]", Owner, Number, Company, Model, Color);
        }
    }
}
