using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator {
    class Program {
        // The Program code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public void ProgramCode(Component component) {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
