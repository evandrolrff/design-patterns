using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight {

    // The Flyweight stores a common portion of the state (also called intrinsic
    // state) that belongs to multiple real business entities. The Flyweight
    // accepts the rest of the state (extrinsic state, unique for each entity)
    // via its method parameters.
    class Flyweight {
        private Car _sharedState;

        public Flyweight(Car car) {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState) {
            string s = this._sharedState.toString();
            string u = uniqueState.toString();     
            Console.WriteLine("Flyweight: Displaying shared {0} and unique {1} state.", s, u);
        }
    }
}
