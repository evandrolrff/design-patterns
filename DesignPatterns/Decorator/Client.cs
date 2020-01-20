using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator {
    class Client {
        public Client() {
            Program program = new Program();

            var simple = new ConcreteComponent();
            Console.WriteLine("Program: I get a simple component:");
            program.ProgramCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Program: Now I've got a decorated component:");
            program.ProgramCode(decorator2);
        }
    }
}
