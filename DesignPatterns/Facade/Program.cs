using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade {
    class Program {
        // The program code works with complex subsystems through a simple
        // interface provided by the Facade. When a facade manages the lifecycle
        // of the subsystem, the client might not even know about the existence
        // of the subsystem. This approach lets you keep the complexity under
        // control.
        public static void ProgramCode(Facade facade) {
            Console.Write(facade.Operation());
        }
    }
}
